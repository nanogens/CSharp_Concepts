using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace B
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private double lastNumber, result;
		SelectedOperator selectedOperator;

		public MainWindow() // constructor
		{
			InitializeComponent();

			lastNumber = 0;
			result = 0;

			//result_Label.Content = "14321";


			// Putting in the stuff below makes the function execute twice (or more?) 
			// because its activated from .xaml AND here as well (both detect the button
			// press and run the same function back to back).
			/*
			ac_Button.Click += ac_Button_Click;
			positivenegative_Button.Click += positivenegative_Button_Click;
			percentage_Button.Click += percentage_Button_Click;
			equals_Button.Click += equals_Button_Click;


			seven_Button.Click += number_Button_Click;
			three_Button.Click += number_Button_Click;
			multiply_Button.Click += operation_Button_Click;
			plus_Button.Click += operation_Button_Click;
			*/
		}

		private void equals_Button_Click(object sender, RoutedEventArgs e)
		{
			double newNumber;
			if (double.TryParse(result_Label.Content.ToString(), out newNumber)) // number in the result_Label saved in lastNumber
			{
				switch(selectedOperator)
				{
					case SelectedOperator.Addition:
						result = SimpleMath.Add(lastNumber, newNumber);
						break;
					case SelectedOperator.Subtraction:
						result = SimpleMath.Subtract(lastNumber, newNumber);
						break;
					case SelectedOperator.Multiplication:
						result = SimpleMath.Multiply(lastNumber, newNumber);
						break;
					case SelectedOperator.Division:
						result = SimpleMath.Divide(lastNumber, newNumber);
						break;
					default:
						break;
				}
				result_Label.Content = result.ToString();
			}
		}

		private void percentage_Button_Click(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(result_Label.Content.ToString(), out lastNumber))
			{
				lastNumber = lastNumber / 100;
				result_Label.Content = lastNumber.ToString();
			}
		}

		private void positivenegative_Button_Click(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(result_Label.Content.ToString(), out lastNumber))
			{
				lastNumber = -lastNumber;
				result_Label.Content = lastNumber.ToString();
			}
		}

		private void ac_Button_Click(object sender, RoutedEventArgs e)
		{
			lastNumber = 0;
			result_Label.Content = "0";
		}

		private void operation_Button_Click(object sender, RoutedEventArgs e)
		{
			if (double.TryParse(result_Label.Content.ToString(), out lastNumber)) // number in the result_Label saved in lastNumber
			{
				result_Label.Content = "0"; // assign the result_Label to accept the next number
			}

			if (sender == multiply_Button)
			{
				selectedOperator = SelectedOperator.Multiplication;
			}
			else if (sender == division_Button)
			{
				selectedOperator = SelectedOperator.Division;
			}
			else if (sender == plus_Button)
			{
				selectedOperator = SelectedOperator.Addition;
			}
			else if (sender == minus_Button)
			{
				selectedOperator = SelectedOperator.Subtraction;
			}
		}

		private void decimal_Button_Click(object sender, RoutedEventArgs e)
		{
			if (result_Label.Content.ToString().Contains("."))
			{
				// Do nothing
			}
			else
			{
				result_Label.Content = $"{result_Label.Content}.";
			}
		}

		private void number_Button_Click(object sender, RoutedEventArgs e)
		{
			int selectedValue = 0;

			if(sender == zero_Button)
			{
				selectedValue = 0;
			}
			else if(sender == one_Button)
			{
				selectedValue = 1;
			}
			else if (sender == two_Button)
			{
				selectedValue = 2;
			}
			else if (sender == three_Button)
			{
				selectedValue = 3;
			}
			else if (sender == four_Button)
			{
				selectedValue = 4;
			}
			else if (sender == five_Button)
			{
				selectedValue = 5;
			}
			else if (sender == six_Button)
			{
				selectedValue = 6;
			}
			else if (sender == seven_Button)
			{
				selectedValue = 7;
			}
			else if (sender == eight_Button)
			{
				selectedValue = 8;
			}
			else if (sender == nine_Button)
			{
				selectedValue = 9;
			}

			if (result_Label.Content.ToString() == "0")
			{
				result_Label.Content = $"{selectedValue}";
			}
			else
			{
				result_Label.Content = $"{result_Label.Content}{selectedValue}";
			}
		}
	}

	public enum SelectedOperator
	{
		Addition,
		Subtraction,
		Multiplication,
		Division
	}

	public class SimpleMath
	{
		public static double Add(double n1, double n2)
		{
			return n1 + n2;
		}
		
		public static double Subtract(double n1, double n2)
		{
			return n1 - n2;
		}

		public static double Multiply(double n1, double n2)
		{
			return n1 * n2;
		}

		public static double Divide(double n1, double n2)
		{
			if (n2 == 0)
			{
				MessageBox.Show("Division by 0 is not supported", "Wrong operation", MessageBoxButton.OK, MessageBoxImage.Error);
				return 0;
			}
			return n1 / n2;
		}
	}
}

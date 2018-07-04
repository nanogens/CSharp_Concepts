using System;

namespace CSharp_Concepts
{
	class Customer
	{
        string _name;
        int _accno;
        int _balance;

        public Customer(string n, int a, int b)
        {
            _name = n;
            _accno = a;
            _balance = b;
        }
        public void Withdraw(int amt)
        {
            if (_balance - amt <= 100)
            {
                throw new BankException(_accno, _balance);
            }
        }
        public int GetBalance()
        {
            return _balance;
        }
	}

    class BankException : Exception
    {
        int _acc;
        int _bal;

        public BankException(int a, int b)
        {
            _acc = a;
            _bal = b;
        }
        public void Inform()
        {
            Console.Write("\n Account Number : " + _acc + " Balance left : " + _bal);
        }
    }
}

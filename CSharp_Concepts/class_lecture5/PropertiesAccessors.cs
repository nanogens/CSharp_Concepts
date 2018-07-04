using System;

namespace CSharp_Concepts
{
    class PropertiesAccessors
    {
        int length;
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
    }
}

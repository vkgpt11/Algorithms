using System;
using System.Collections.Generic;
using System.Text;

namespace StringAlgorithms.Math
{
    class SwappingNumbers
    {
        private int number1, number2;
        public int Number1
        {
            get
            {
                return number1;
            }
        }

        public int Number2
        {
            get
            {
                return number2;
            }
        }

        public SwappingNumbers(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public void Swapping1()
        {
            int temp;
            temp = number2;
            number2 = number1;
            number1 = temp;
        }

        public void Swapping2()
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
        }
        public void Swapping3()
        {
            number1 = number1 ^ number2;
            number2 = number1 ^ number2;
            number1 = number1 ^ number2;
        }
    }
}

using System;
using System.Numerics;

namespace TestApp
{
    public class TestClass
    {

        public delegate void SendResult(int number);
        public SendResult toSend;

        public void TMethod()
        {
            Console.WriteLine("Print Something");
        }

        public void CalculateFactorial(int number)
        {
            int result = number;
            for(int i = 1; i < number; i++)
            {
                result = result * i;
            }

            toSend.Invoke(result);
        }

    }
}

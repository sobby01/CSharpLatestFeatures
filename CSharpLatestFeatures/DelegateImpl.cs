using System;
using System.Collections.Generic;
using System.Text;
using TestApp;

namespace CSharpLatestFeatures
{
    public class DelegateImpl
    {
        TestClass tClass = new TestClass();
        
        public void TestDelegate()
        {
            tClass.toSend = CallBackMethod;
            tClass.CalculateFactorial(5);
        }

        public void CallBackMethod(int value)
        {
            Console.WriteLine(value);
        }
    }
}

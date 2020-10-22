using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLatestFeatures
{
    public class ExpressionBodyMethod
    {
        public void ShowName() => Console.WriteLine("My name is Saurabh");

        public void PrintShowName()
        {
            ShowName();
        }
    }
}

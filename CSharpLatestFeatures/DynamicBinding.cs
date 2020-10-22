using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLatestFeatures
{
    public class DynamicBinding
    {
        public void DynamicMethod()
        {
            dynamic v = 1;
            object v1 = 1;

            Console.WriteLine(v.GetType());
            Console.WriteLine(v1.GetType());
        }
    }
}

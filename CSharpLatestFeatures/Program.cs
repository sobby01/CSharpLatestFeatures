    using System;

namespace CSharpLatestFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateImpl dImpl = new DelegateImpl();
            dImpl.TestDelegate();
            Console.ReadKey();
            return;
            DynamicBinding dBinding = new DynamicBinding();
            dBinding.DynamicMethod();
            Console.ReadKey();
        }
    }
}

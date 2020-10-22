    using System;

namespace CSharpLatestFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicBinding dBinding = new DynamicBinding();
            dBinding.DynamicMethod();
            Console.ReadKey();
        }
    }
}

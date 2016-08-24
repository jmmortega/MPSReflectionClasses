using System;

namespace SampleMSPReflection_1
{
    public class Foo
    {
        public int FooQuantity { get; set; }

        public string FooName { get; set; }

        private void HelloWorld()
        {
            var stack = Environment.StackTrace;
            Console.WriteLine("Hello world");
        }

        //A way to override equals
        public override bool Equals(object obj)
        {
            var foo = (Foo)obj;
            return FooQuantity == foo.FooQuantity;
        }

        public override int GetHashCode()
        {
            return FooQuantity.GetHashCode() ^ FooName.GetHashCode();
        }
    }
}

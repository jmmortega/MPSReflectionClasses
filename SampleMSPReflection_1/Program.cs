using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMSPReflection_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo();
            var foo2 = new Foo();

            if(foo.Equals(foo2))
            {
                Console.WriteLine("Foo it's equals");
            }

            //Access to properties from any Object                        
            var propertyInt = foo.GetType().GetProperties().First();
            //And asign a dynamic value
            propertyInt.SetValue(foo, 5);                        
            Console.WriteLine(foo.FooQuantity);


            //You can invoke private methods!!!
            var helloWorld = foo.GetType().GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).First(x => x.Name.Contains("HelloWorld"));
            helloWorld.Invoke(foo, new object[] { });

             
            Console.ReadKey();
        }
    }
}

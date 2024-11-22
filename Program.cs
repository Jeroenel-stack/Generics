using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Choices cdtest = new Choices();
            cdtest.testing();

        }
        public static void Option()
        {
            Console.WriteLine("\nOPTION");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Read Student");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
        }
        public static void test()
        {
            Console.WriteLine("CHOOSE 1 TO TEST");
            Console.WriteLine("1. Repository<Student> ");
            Console.WriteLine("2. DictionaryRepository<int, Product> ");
        }
        public static void Option2()
        {
            Console.WriteLine("\nOPTION");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Read Product");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
        }
    }
}

      
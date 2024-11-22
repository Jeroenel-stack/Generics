using System;

namespace Generics
{
    public class Choices
    {
        public int choose;
        Crud cd = new Crud();
        Crud2 cd2 = new Crud2();
        public void testing()
        {
            Program.test();
            Console.Write("Choose to Test:");
            choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    Console.WriteLine("\n=STUDENT REPOSITORY MANAGEMENT=");
                    cd.Introduce();
                    break;
                case 2:
                    Console.WriteLine("\n=PRODUCT REPOSITORY MANAGEMENT=");
                    cd2.SecondIntroduce();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

    }
}

        
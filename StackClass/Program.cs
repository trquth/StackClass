using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int capaticy;
            Console.WriteLine("Enter capacity of Stack");
            capaticy = int.Parse(Console.ReadLine());
            MyStack<string> stack = new MyStack<string>(capaticy);
            //chon chon chu nang 
            Console.WriteLine("1.Push");

            int choise;
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine("Enter string to Stack");
                        string temp = Console.ReadLine();
                        int result = stack.Push(temp);
                        if (result != -1)
                        {
                            Console.WriteLine("Element pushed into Stack");
                        }
                        else
                        {
                            Console.WriteLine("Stack overflow");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You have entered wrong choise");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}

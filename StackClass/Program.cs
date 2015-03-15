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
        back: capaticy = int.Parse(Console.ReadLine());
            if (capaticy <= 0)
            {
                Console.WriteLine("Sorry, you enter a different value for capacity of Stack");
                goto back;
            }
            MyStack<string> stack = new MyStack<string>(capaticy);
            //chon chon chu nang 
            Console.WriteLine("1.Push");
        choiseMethod:
            Console.WriteLine("2.Pop");
            Console.WriteLine("3.Peep");

            int choise;
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    {
                        Console.WriteLine("Enter string to Stack");
                        while (capaticy != 0)
                        {
                            string temp = Console.ReadLine();
                            stack.Push(temp);
                            capaticy--;
                            if (capaticy == 0)
                            {
                                Console.WriteLine("Element pushed into Stack");
                                goto choiseMethod;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        string result = stack.Pop();
                        if (result != null)
                        {
                            Console.WriteLine("Delete element: " + result);
                            goto choiseMethod;
                        }
                        else
                        {
                            Console.WriteLine("Stack unoverflow");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter position of Element to Pop");
                        int position = int.Parse(Console.ReadLine());
                        string result = stack.Peep(position);
                        if (result != null)
                        {
                            Console.WriteLine("Element at position " + position + "is " + result);
                            goto choiseMethod;
                        }
                        else
                        {
                            Console.WriteLine("Entered element is out of Stack element");
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

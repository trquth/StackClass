using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    class Program
    {
        //Tran Quan Thien 1151020157
        static void Main(string[] args)
        {
            int capacity;
            Console.WriteLine("Enter capacity of Stack");
        back: capacity = int.Parse(Console.ReadLine());
            if (capacity <= 0)
            {
                Console.WriteLine("Sorry, you enter a different value for capacity of Stack");
                goto back;
            }
            MyStack<string> stack = new MyStack<string>(capacity);
            Console.WriteLine("1.Push");
        choiseMethod:
            Console.WriteLine("2.Pop");
            Console.WriteLine("3.Peep");

            int choice;//sai chinh ta, da sua
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter string to Stack");
                        while (capacity != 0)
                        {
                            string temp = Console.ReadLine();
                            stack.Push(temp);
                            capacity--;
                            if (capacity == 0)
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
                        string result = stack.Peek(position);
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

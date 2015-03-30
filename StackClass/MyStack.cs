using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    class MyStack<T>
    {
        int capacity;
        T[] stack;
        int top;
        public MyStack(int maxElement)
        {
            capacity = maxElement;
            stack = new T[capacity];
            //Initialize the initial value by 1
            top = -1;
        }
        /// <summary>
        ///  Add new value to the STACK
        /// </summary>
        /// <param name="element"></param>
        public void Push(T element)
        {
            //kiem tra xem mang co bi tran k
            if (top ==capacity-1)
            {
                return ;
            }
            else
            {
                top = top + 1;
                stack[top] = element; 
            }
            return ;
        }
        /// <summary>
        /// Returns the element at the top and top-down processing decreased 1
        /// </summary>
        /// <returns>Returns the first value of the stack if not empty, otherwise it returns the default value depends on the parameter T</returns>
        public T Pop()
        {
            T removeElement;
            T temp = default(T);
            if (!(top<=0))
            {
                removeElement = stack[top];
                top = top - 1;
                return removeElement;
            }
            return temp;
        }
        /// <summary>
        /// Returns the value at any position in the STACK
        /// </summary>
        /// <param name="position">Value of type int</param>
        /// <returns>Returns the value at the location where the user needs, returns the default value depends on the T</returns>
        public T Peek(int position)
        {
            T temp = default(T);
            if (position< capacity&& position>=0)
            {
                return stack[position];
            }
            return temp;
        }
    }
}

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
            //khoi tao gia tri cho top -1
            top = -1;
        }
        /// <summary>
        /// Ham them gia tri vao Stack
        /// </summary>
        /// <param name="element">gia tri bat ki phu thuoc vao T</param>
        /// <returns>tra ve -1 neu Stack da day va 0 khi da them tat ca phan tu vao Stack</returns>
        public int Push(T element)
        {
            //kiem tra xem mang co bi tran k
            if (top ==capacity-1)
            {
                return -1;
            }
            else
            {
                top = top + 1;
                stack[top] = element; 
            }
            return 0;
        }
    }
}

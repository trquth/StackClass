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
        /// Tra ve mot phan tu o dau  va giam top xuong 1
        /// </summary>
        /// <returns>tra ve gia tri dau neu Stack khong rong, tra ve gia tri mac dinh phu thuoc vao T neu Stack rong    </returns>
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
        /// Tra ve mot phan tu o vi tri bat ki
        /// </summary>
        /// <param name="position">gia tri kieu int</param>
        /// <returns>Neu Stack rong tra ve gia tri mac dinh, nguoc lai tra ve mot gia tri thuoc Stack o vi tri do nguoi dung chi dinh</returns>
        public T Peep(int position)
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

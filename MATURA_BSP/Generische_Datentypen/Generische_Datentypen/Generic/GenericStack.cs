using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generische_Datentypen.Generic
{
    class GenericStack<T>
    {
        private readonly int size;
        private T[] elements;
        private int pointer = 0;

        public GenericStack(int size)
        {
            this.size = size;
            this.elements = new T[size];
        }

        public void Push(T element)
        {
            if (pointer >= this.size)
                throw new StackOverflowException();
            elements[pointer] = element;
            pointer++;
        }

        public T Pop()
        {
            pointer--;
            if (pointer >= 0)
                return elements[pointer];
            else
            {
                pointer = 0;
                throw new InvalidOperationException("Der Stack ist leer");
            }
        }

        public int Length
        {
            get { return this.pointer; }
        }
    }
}

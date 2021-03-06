﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generische_Datentypen.Generic
{
    class Stack
    {
        private readonly int size;
        private Object[] elements;
        private int pointer = 0;

        public Stack(int size)
        {
            this.size = size;
            this.elements = new Object[size];
        }

        public void Push(object element)
        {
            if (pointer >= this.size)
                throw new StackOverflowException();
            elements[pointer] = element;
            pointer++;
        }

        public object Pop()
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

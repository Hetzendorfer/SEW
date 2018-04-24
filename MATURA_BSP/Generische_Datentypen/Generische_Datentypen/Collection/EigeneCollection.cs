using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generische_Datentypen.Collection
{
    class EigeneCollection<T> : IEnumerable<T>, ICollection<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        private List<T> liste = new List<T>();

        public void Add(T item)
        {
            liste.Add(item);
        }

        public void Clear()
        {
            this.liste.Clear();
        }

        public bool Contains(T item)
        {
            return this.liste.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.liste.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.liste)
            {
                yield return item;
            }
        }

        public bool Remove(T item)
        {
            return this.liste.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (T item in this.liste)
            {
                yield return item;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class MyCollection
    {
        public int[] storage = new int[4];
        public int Count
        {
            get;
            private set;
        }
        public void Add(int x)
        {
            if (Count > storage.Length-1)
            {
                int [] temp = storage;
                storage = new int[storage.Length*2];
                for (int i=0; i<temp.Length; i++)
                {
                    storage[i] = temp[i];
                }
            }
            storage[Count] = x;
            Count++;


            OnElementAdd?.Invoke();
            
        }
        public void RemoveAt(int x)
        {
            for (int i = x; i<storage.Length-1; i++)
            {
                storage[i] = storage[i + 1];
            }
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > storage.Length-1)
                {
                    throw new IndexOutOfRangeException("Index out of range");   
                }
                else return storage[index];
            }  
        }
        public event CollectionDelegate OnElementAdd;

        

    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] items;

        public MyDictionary()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempItem = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempItem.Length; i++)
            {
                items[i] = tempItem[i];
            }

            items[items.Length - 1] = item;
        }

        public int Count
        {
            get { return items.Length; }

        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WierdBrainCoffee.StorageApp.Entities;

namespace WierdBrainCoffee.StorageApp.Reposatory
{
    public class ListRepository<T> : IRepository<T> where T : IEntity, new()//If you write T : class, IEntity it can be nullable otherWise It can't be nullable
    {
        
        private readonly List<T> _items = new ();

        //public T CreateItems()
        //{
        //    return new T();
        //}

        public T GetID(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }


        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
    }


}

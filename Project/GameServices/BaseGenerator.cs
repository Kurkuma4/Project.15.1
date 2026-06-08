using Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.GameServices
{
    public abstract class BaseGenerator<T>
    {
        protected Random rnd = new Random();

        protected List<string> names = new List<string>();
        public abstract T CreateOne();

        public List<T> CreateMany(int count)
        {
            List<T> list = new List<T>();

            for (int i = 0; i < count; i++)
            {
                list.Add(CreateOne());
            }

            return list;
        }
    }
}

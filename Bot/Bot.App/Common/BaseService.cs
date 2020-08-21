using Bot.App.Abstract;
using Bot.Domains.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bot.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }

        public int AddNewItem(T item)
        {
            Items.Add(item);
            return item.ID;
        }

        public void DeleteItem(T item)
        {
            Items.Remove(item);
        }

        public List<T> GetAllItems()
        {
            return Items;
        }

        public int GetLastID()
        {
            int id;
            if (Items.Any())
            {
                id = Items.OrderBy(i => i.ID).LastOrDefault().ID;
            }
            else
            {
                id = 0;
            }
            return id;
        }


    }
}

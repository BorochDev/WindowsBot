using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.App.Abstract
{
    public interface IService<T>
    {
        List<T> Items { get; set; }

        int GetLastID();
        int AddNewItem(T item);
        void DeleteItem(T item);
        List<T> GetAllItems();
    }
}

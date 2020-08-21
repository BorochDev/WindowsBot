using Bot.Domains.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.Domains.Entity
{
    public class Command : BaseEntity
    {
        public string Path { get; set; }

        public Command(int id, string name, string path)
        {
            ID = id;
            Name = name;
            Path = path;
        }
    }
}

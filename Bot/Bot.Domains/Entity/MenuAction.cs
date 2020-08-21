using Bot.Domains.Common;
using Bot.Domains.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bot.Domains.Entity
{
    public class MenuAction : BaseEntity
    {
        public string Description { get; set; }
        public BranchType Branch { get; set; }

        public MenuAction(int id, string name, string description, BranchType branch)
        {
            ID = id;
            Name = name;
            Description = description;
            Branch = branch;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chloe.Entity
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute() { }
        public ColumnAttribute(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public bool IsPrimaryKey { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLINQ.service.attribute
{
    class RoleInfoAttribute : System.Attribute
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public RoleInfoAttribute()
        { }

        public RoleInfoAttribute(string name)
        {
            Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using LambdaAndLINQ.service.attribute;
using LambdaAndLINQ.utils;

namespace LambdaAndLINQ.model
{
    [RoleInfo("Manager")]
    class Admin
    {
        public string Name { get; set; }
        public Admin(string n)
        {
            Name = n;
        }

        public Admin()
        {
            throw new ExceptionCreatingInstance("Custom exception isWorked");
        }

        private int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }
    }
}

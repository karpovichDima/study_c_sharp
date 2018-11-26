using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLINQ.service
{
    interface IUserService
    {
        void CreateNewUsers(string name);
        int GetCountUsers();
        HashSet<User> GetUserSet();
        void SetKeysInArray(int counter);
    }
}

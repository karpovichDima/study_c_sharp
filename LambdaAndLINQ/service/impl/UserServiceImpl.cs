using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLINQ.service.impl
{
    class UserServiceImpl : IUserService
    {
        private HashSet<User> userSet;
        private int[] keys;

        public UserServiceImpl()
        {
            this.userSet = new HashSet<User>();
            keys = new int[5];
        }

        public void CreateNewUsers(String name)
        {
            User user = new User(name);
            userSet.Add(user);
        }

        public int GetCountUsers()
        {
            return userSet.Count;
        }

        public HashSet<User> GetUserSet()
        {
            return userSet;
        }

        public void SetKeysInArray(int counter)
        {
            keys[counter - 1] = counter;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLINQ.service.impl
{
    class UserServiceImpl : IUserService
    {
        private HashSet<User> userSet;
        private int[] keys;
        private List<User> users;

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

        public int CalculateSumOfAges((int, int) tuple)
        {
            return tuple.Item1 + tuple.Item2;
        }

        public List<User> ReplaceSetToList(HashSet<User> set)
        {
            List<User> userList = new List<User>(set);
            return userList;
        }

        public void SortingList(List<User> users)
        {
            users.Sort();
            this.users = users;
        }

        public List<User> ReplaceUserSetToList()
        {
            List<User> userList = new List<User>(userSet);
            return userList;
        }

        public void DeleteUsersLowerThan10Years(string consoleLine)
        {
            if (consoleLine == "Delete")
            {
                var listToDelete = new List<User>();
                int usersCount = users.Count;
                this.users.RemoveAll(UserLowerThan10AgePredicate);
            }
        }


        private static bool UserLowerThan10AgePredicate(User user)
        {
            return user.Age < 10;
        }
    }
}
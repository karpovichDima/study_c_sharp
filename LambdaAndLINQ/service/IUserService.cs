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
        int CalculateSumOfAges((int, int) tuple);
        List<User> ReplaceSetToList(HashSet<User> set);
        void SortingList(List<User> users);
        List<User> ReplaceUserSetToList();
    }
}

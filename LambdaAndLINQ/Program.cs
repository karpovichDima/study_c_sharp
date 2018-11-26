using System;
using System.Collections.Generic;
using LambdaAndLINQ.service;
using LambdaAndLINQ.service.impl;

namespace LambdaAndLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IUserService iUserService = new UserServiceImpl();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("set User name");
                iUserService.CreateNewUsers(Console.ReadLine());
                Console.WriteLine("\r\n");
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("Count of the element: " + iUserService.GetCountUsers());

            int counter = 1;
            
            List<User> users = iUserService.ReplaceUserSetToList();
            iUserService.SortingList(users);
            
            foreach (var user in users)
            {
                iUserService.SetKeysInArray(counter);
                Console.WriteLine(counter + ": Name: " + user.Name + "\r\n" + "Age: " + user.Age + "\r\n");
                counter++;
            }
            var tuple = (users[0].Age, users[1].Age);
            int calculateSumOfAges = iUserService.CalculateSumOfAges(tuple);
            Console.WriteLine("Sum of the ages for first and second user: " + calculateSumOfAges + "\r\n");

            iUserService.DeleteUsersLowerThan10Years(Console.ReadLine());
            Console.WriteLine("Users older than 10 years: " + users.Count + "\r\n");

            ListUserToConsole(users);
            
            Console.ReadKey();
        }

        private static void ListUserToConsole(List<User> users)
        {
            int counter = 1;
            foreach (var user in users)
            {
                Console.WriteLine(counter + ": Name: " + user.Name + "\r\n" + "Age: " + user.Age + "\r\n");
                counter++;
            }

        }
    }
    
}
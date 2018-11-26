using System;
using System.Collections.Generic;
using LambdaAndLINQ.service;
using LambdaAndLINQ.service.impl;

namespace LambdaAndLINQ
{
    public class Program
    {
        public static Int16 USERS_COUNT = 5;

        public delegate void OutputTextToConsole(string text);
        public static event OutputTextToConsole RowCreated;

        public static void Main(string[] args)
        {
            IUserService iUserService = new UserServiceImpl();
           
            OutputTextToConsole output = (string text) => Console.WriteLine(text);
            RowCreated += iUserService.ShowMessageEvent;

            for (int i = 0; i < USERS_COUNT; i++)
            {
                output("set User name");
                iUserService.CreateNewUsers(Console.ReadLine());
                output("\r\n");
                RowCreated("---- EVENT - Was created empty row ----");
            }

            output("\r\n");
            output("Count of the element: " + iUserService.GetCountUsers());

            int counter = 1;
            
            List<User> users = iUserService.ReplaceUserSetToList();
            iUserService.SortingList(users);
            
            foreach (var user in users)
            {
                iUserService.SetKeysInArray(counter);
                output(counter + ": Name: " + user.Name + "\r\n" + "Age: " + user.Age + "\r\n");
                counter++;
            }
            var tuple = (users[0].Age, users[1].Age);
            int calculateSumOfAges = iUserService.CalculateSumOfAges(tuple);
            output("Sum of the ages for first and second user: " + calculateSumOfAges + "\r\n");

            iUserService.DeleteUsersLowerThan10Years(Console.ReadLine());
            output("Users older than 10 years: " + users.Count + "\r\n");

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
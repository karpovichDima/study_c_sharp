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
            HashSet<User> userSet = iUserService.GetUserSet();
            foreach (var user in userSet)
            {
                iUserService.SetKeysInArray(counter);
                Console.WriteLine(counter + ": Name: " + user.Name + "\r\n" + "Age: " + user.Age + "\r\n");
                counter++;
            }

            Console.ReadKey();
        }
    }
    
}
using System;
using System.Collections.Generic;

namespace LambdaAndLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<User> userSet = new HashSet<User>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("set User name");
                var readLine = Console.ReadLine();
                User user = new User(readLine);
                userSet.Add(user);
            }

            Console.WriteLine("Count of the element: " + userSet.Count);

            foreach (var user in userSet)
            {
                Console.WriteLine("Name: " + user.Name + "\r\n" + "Age: " + user.Age + "\r\n");
            }

            Console.ReadKey();

        }
    }
    
}
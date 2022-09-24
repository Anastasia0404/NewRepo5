using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User("user123", "Ivan", "Skoropatskiy", 23, new Date(5, 2, 2022));
            user.PrintInfo();
        }
    }
}
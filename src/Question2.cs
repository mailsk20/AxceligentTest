using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    public class Question2
    {
        public void UserClass()
        {
            while (true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }

                user.Add(userName);
                Console.WriteLine($"number of addedUser {user.GetUsersCount()}");
            }
        }
        public class User
        {
            private static User _instance;
            private static List<string> _users;
            private static readonly object _lock = new object();

            public User(bool isConstructor = true)
            {
                lock (_lock)
                {
                    if (_instance == null && isConstructor)
                    {
                        _instance = new User(false);
                        _users = new List<string>();
                    }
                }
            }

            public void Add(string name)
            {
                _users.Add(name);
            }

            public int GetUsersCount()
            {
                return _users.Count;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace MessagesManager
{
    class User
    {
        public string Username { get; set; }
        public int MessageRecieved { get; set; }
        public int MessageSent { get; set; }
    }

    class Program
    {
        void Main(string[] args)
        {
            List<User> users = new List<User>();

            int capacity = int.Parse(Console.ReadLine());
            // string command 
            string[] commandArgs;

            while ((commandArgs = Console.ReadLine().Split("="))[0] != "Statistics")
            {
                //Add
                if(commandArgs[0] == "Add")
                {
                    AddUser(users, commandArgs[1], int.Parse(commandArgs[2]),int.Parse(commandArgs[3]));
                }

                //Message
                if (commandArgs[0] == "Message")
                { 
                    string senderUsername = commandArgs[1];
                    string receiverUsername = commandArgs[2];

                    if(users.Any(u => u.Username == senderUsername) && users.Any(u => u.Username == receiverUsername))
                    {
                        User sender = users.Find(u => u.Username == senderUsername);
                        User receiver = users.Find(u => u.Username == receiverUsername);

                        sender.MessageSent++;
                        receiver.MessageRecieved++;

                        if(sender.MessageSent + sender.MessageRecieved >= capacity)
                        {
                            Console.WriteLine($"{sender.Username} reached the capacity!");
                            users.Remove(sender);
                        }

                        if (receiver.MessageSent + receiver.MessageRecieved >= capacity)
                        {
                            Console.WriteLine($"{receiver.Username} reached the capacity!");
                            users.Remove(receiver);
                        }
                    }
                }

                //Empty
                if (commandArgs[0] == "Empty")
                {
                    if(users.Any(u => u.Username == commandArgs[1]))
                    {
                        User userToDelete = users.Find(u => u.Username == commandArgs[1]);

                        users.Remove(userToDelete);
                    }
                    else if (commandArgs[1] == "All")
                    {
                        users = new List<User>();
                    }
                }
            }
            //Statistics command code
            Console.WriteLine("Users count: " + users.Count);

            foreach (User user in users)
            {
                Console.WriteLine(user.Username + " - " + (user.MessageRecieved + user.MessageSent));
            }
        }

        public void AddUser(List<User> users, string userName, int messageRecieved, int messageSent)
        {
            if (!users.Any(u => u.Username == userName))
            {
                User currentUser = new User()
                {
                    Username = userName,
                    MessageSent = messageRecieved,
                    MessageRecieved = messageSent
                };

                users.Add(currentUser);
            }
        }


    }
}

using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ForumUser clark = new ForumUser("admin", "addmin", 999);
            clark.CreateMessage();

            //User carl = new User("customer", "customer", 555);
            //carl.CreateMessage();

           Console.WriteLine(clark.GetRole());
            
        }


    }

    public class User
    {
        public string role { get; set; }
        public string login;
        public int password;


        public User(string r, string l, int p)
        {
            role = r;
            login = l;
            password = p;
        }
        public string GetRole()
        {
           string getrole = role;

            return getrole;
           
        }

    }

     public class ForumUser : User
    {
        public ForumUser (string r, string l, int p) : base ( r,  l, p)
        {
           
        }
        public void CreateMessage()
        {
            Console.WriteLine($"Role:  {role} \nLogin: {login} \nPassword: {password}");
        }

       
    }
 
}



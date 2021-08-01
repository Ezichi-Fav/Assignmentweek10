using System;
using System.Collections;
using System.IO;

namespace user_mamagement_app
{
    public class Program

    {

        public static void Main()
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("username: pinky " + " Hobby: Card games " + " Email: pinkydot@gmail.com ");
            myQueue.Enqueue("username: Ruby " + " Hobby: swimming " + " Email: rubydot@gmail.com");
            myQueue.Enqueue("username:ice " + " Hobby:skating " + " Email:icedot@gmail.com");
            myQueue.Enqueue("username:ice " + " Hobby:skating " + " Email:icedot@gmail.com");
            myQueue.Enqueue("username:chinny " + " Hobby:reading " + " Email:chinnydot@gmail.com");
            myQueue.Enqueue("username:koala " + " Hobby:sleeping " + " Email:sleepingdot@gmail.com");
            Console.WriteLine($"Total Users = {myQueue.Count}");
            foreach (var e in myQueue)
                
            Console.WriteLine("username:pinky " + " Hobby:Card games " + " Email:pinkydot@gmail.com ");
            Console.WriteLine("username:Ruby " + " Hobby:swimming " + " Email:rubydot@gmail.com ");
            Console.WriteLine("username:ice " + " Hobby:skating " + " Email:icedot@gmail.com ");
            Console.WriteLine("username:chinny " + " Hobby:reading " + " Email:chinnydot@gmail.com ");
            Console.WriteLine("username:koala " + " Hobby:sleeping " + " Email:sleepingdot@gmail.com ");


           FileStreamClass.FileStore();

        } }

        }

        
            
        
        
    


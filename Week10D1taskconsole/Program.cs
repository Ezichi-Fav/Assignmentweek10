using System;
using System.Collections.Generic;

namespace Week10D1taskconsole
{
    class Program
    {
        static void Main()
        {
            
            bool Equal = SameChar.DiffChar<List>(8, "bee", '+', false, 7.7);
            if (Equal)
            {
                Console.WriteLine(true);
            }
            else
            {

                Console.WriteLine(false);


            }



        }

        public class SameChar
        {
            public static bool DiffChar<list>(object val1, object val2, object val3, object val4, object val5)
            {

                if (val1 == val2 && val3 == val4 || val4 == val5)
                    return true;
                else
                {

                    return false;
                }


            }






        }
    }
    
    internal class List
    {
    }
}
































            //public static void hashTable()
           // {
              //  HashTable hashTable = new HashTable();

               // hashTable.Add(1, "Book");
                //hashTable.Add(2, "Pen");
                //hashTable.Add(4, 'p');
                //hashTable.Add(7, 5);
                //hashTable.Add(9, true);

                //var val =  hashTable(5);
                //var val2 = hashTable(1);
                //System.Console.WriteLine(val);
                //System.Console.WriteLine(val2);

            



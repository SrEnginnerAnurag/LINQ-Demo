using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    public  class LINQ_CLass
    {
        //LINQ = Language , Integreted , Query
        public void LINQMethod()
        {
         int[] Age = { 15,16,19,20,22,25,28,30,32,33,40,45,50 };  // this is the data source.

            var Result1 = from New in Age select New; // show all data by linq
            foreach (var A in Result1)
            {
                Console.WriteLine(A);
            }
            Console.WriteLine("------------------------------------------------");

            var Result2 = from new2 in Age where new2 >= 20 select new2; // use where for condition
            var rws = Age.First();
            foreach (var B in Age)
            {
                Console.WriteLine(B);
            }
            Console.WriteLine("------------------------------------------------");

            var Result3 = from a in Age where a >= 20 orderby a descending select a;// use order by operator 
            foreach (var C in Result3)
            {
                Console.WriteLine(C);
            }
            Console.WriteLine("------------------------------------------------");

            var Result4 = from d in Age where d <= 20 orderby d select d; // use order by oprator 

            foreach (var D in Result4)
            {
                Console.WriteLine(D);
            }

            Console.WriteLine(" String type LINQ. -------------------");


            string[] StudentName = { "Anurag", "Aman", "Virat", "Shubham", "Bipul", "Bipul", "Golu", "Bittu", "Chhotu" };
            var Answer = from k in StudentName select k;

            foreach (var A in Answer) // Array ko hamesha ForeachLopp / ForLoop se bahar nikala jata hai.
            {
                Console.WriteLine(A);
            }


        }
        public void mthod() { }
        
    }
}

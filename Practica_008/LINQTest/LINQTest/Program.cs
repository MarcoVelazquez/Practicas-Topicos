using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    class jeje
    {
        public string Nombre;
    }
    
    class Program
    {
        

        
        static void Main(string[] args)
        {

            /*string s = "Hello";
            // Because string implements IEnumerable, we can call GetEnumerator():
            IEnumerator rator = s.GetEnumerator();
            while (rator.MoveNext())
            {
                char c = (char)rator.Current;
                Console.Write(c + ".");
            }*/



            /*string s = "Hello"; // The String class implements IEnumerable
            foreach (object c in s)
                Console.Write((char)c + ".");*/

            
            /*string[] names = { "Tomás", "Dick", "Harry" };
            IEnumerable<string> filteredNames = Enumerable.Where(names, a => a.Length > 4);
            foreach (string n in filteredNames)
                Console.WriteLine(n);
            */

            /*
            string[] names = { "Tom", "Dick", "Harry" };
            IEnumerable<string> filteredNames = names.Where(a => a.Length >= 4);
            foreach (string n in filteredNames)
                Console.WriteLine(n);
            
            IEnumerable<string> upper = names.Select(a => a.ToUpper());
            foreach (string n in upper)
                Console.WriteLine(n);
            
            IEnumerable<string> ordenados = names.OrderBy<string, string>(x => x);
            foreach (string n in ordenados)
                Console.WriteLine(n);*/

            string[] names = { "Tom", "Dick", "Harry" };
            /*var lala = from n in names select n.ToUpper(); 
            foreach(string l in lala)
                Console.WriteLine(l);
            
            var lele = from n in names orderby n select n;
            foreach (string l in lele)
                Console.WriteLine(l);*/
            
            var lili = from N in names select new jeje{Nombre = N.ToUpper()};
            foreach(jeje l in lili)
                Console.WriteLine(l.Nombre);

             
        }
    }
}

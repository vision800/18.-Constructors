using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("Faith hub","vision",45);

            Console.WriteLine("Book title : "+book.title);
            Console.WriteLine("Book author : " + book.author );
            Console.WriteLine("Book pages : " + book.pages);

            Console.Read();
        }
    }
}

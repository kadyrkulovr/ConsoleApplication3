using ConsoleApplication3.Data;
using ConsoleApplication3.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new DocumentContext())
            {
                c.Documents.Add(new Document { Id = 1 });
                c.SaveChanges();

            }
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbCrudContext;

namespace ConsoleAppLinQPostgreSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DbCrudDataContext context = new DbCrudDataContext())
            {
                var query = from crud in context.Cruds
                            orderby crud.Id
                            select crud;

                foreach (Crud crud in query)
                {
                    Console.WriteLine("{0} | {1} | {2} | {3}", crud.Id, crud.FirstName, crud.LastName, crud.Gender);
                }

                Console.ReadLine();
            }
        }
    }
}

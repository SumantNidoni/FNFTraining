using Assignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class DBApproach
    {
        static void Main(string[] args)
        {
            try
            {
                var context = new FnftrainingContext();
                context.Products.Add(new Product
                {
                    Name = "Iphone 16 pro max",
                    Description = "Its a very powerful smartphone with max chip",
                    Price = 150000
                });
                context.SaveChanges();
                Console.WriteLine("Inserted Succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}

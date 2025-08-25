namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
                insertExample();
            
        }

        private static void insertExample()
        {
            try
            {
                var context = new BookContext();
                var book = new Book
                {
                    title = "Rich Dad, Poor Dad",
                    author = "Robert",
                    price = 560
                };
                context.Add(book);
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

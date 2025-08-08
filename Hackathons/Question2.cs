using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathons
{
    internal class Question2
    {
        static void Main(string[] args)
        {
            //------------------Second Program------------------
            Console.WriteLine("Enter the number of books");
            int n = int.Parse(Console.ReadLine());

            List<string> books = new List<string>();
            Console.WriteLine("Enter the book entries in format: \"Title\" by Author");

            for (int i = 0; i < n; i++)
            {
                books.Add(Console.ReadLine());
            }

            List<string> sortedTitles = GetSortedBookTitle(books);

            Console.WriteLine("Sorted Book Titles");
            foreach (var title in sortedTitles)
            {
                Console.WriteLine(title);
            }
        }


        public static List<string> GetSortedBookTitle(List<string> books)
        {

            List<BookEntry> bookEntries = new List<BookEntry>();

            foreach (string entry in books)
            {
                string[] parts = entry.Split(" by ");
                string title = parts[0].Trim('\"').Trim();
                string authorPart = parts[1].Trim();

                string firstAuthor = authorPart.Split(',')[0].Trim();

                bookEntries.Add(new BookEntry { Title = title, Author = firstAuthor });
            }



            for (int i = 0; i < bookEntries.Count - 1; i++)
            {
                for (int j = i + 1; j < bookEntries.Count; j++)
                {
                    BookEntry a = bookEntries[i];
                    BookEntry b = bookEntries[j];

                    bool swap = false;

                    int authorCompare = string.Compare(a.Author, b.Author, StringComparison.OrdinalIgnoreCase);

                    if (authorCompare > 0)
                    {
                        swap = true;
                    }
                    else if (authorCompare == 0)
                    {
                        int titleCompare = string.Compare(a.Title, b.Title, StringComparison.OrdinalIgnoreCase);
                        if (titleCompare > 0)
                        {
                            swap = true;
                        }
                    }

                    if (swap)
                    {
                        BookEntry temp = bookEntries[i];
                        bookEntries[i] = bookEntries[j];
                        bookEntries[j] = temp;
                    }
                }
            }


            List<string> sortedTitle = new List<string>();

            foreach (var book in bookEntries)
            {
                sortedTitle.Add(book.Title);
            }
            return sortedTitle;
        }
    }
    class BookEntry
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}



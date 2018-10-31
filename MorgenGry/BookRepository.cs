using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        
        public void AddBook(Book b)
        {
            books.Add(b);
        }
        public Book GetBook(string item)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ItemId == item)
                {
                    return books[i];
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double DidriksLomme = 0;
            for (int i = 0; i < books.Count; i++)
            {
                DidriksLomme += Utility.GetValueOfBook(books[i]);
            }
            return DidriksLomme;
        }
    }
}

using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer;

namespace ServiceLayer
{
    public class BookService : IBookDetails
    {
        public ApplicationContext ApplicationContext;
        public BookService(ApplicationContext applicationContext)
        {
            ApplicationContext = applicationContext;
            
        }
        public void DeleteBook(int id)
        {
            BookDetails b=GetBookDetails(id);
            if(id!=null)
            {
                ApplicationContext.Remove< BookDetails > (b);
                ApplicationContext.SaveChanges();
            }
           
        }

        public IList<BookDetails> GetBookDetails()
        {
            return ApplicationContext.Set<BookDetails>().ToList();

        }

        public BookDetails GetBookDetails(int bid)
        {
            return ApplicationContext.Find<BookDetails>(bid);
        }

        public void InsertBook(BookDetails book)
        {
            ApplicationContext.Add<BookDetails>(book);
            ApplicationContext.SaveChanges();
        }

        public void UpdateBook(BookDetails book)
        {
            ApplicationContext.Update<BookDetails>(book);
            ApplicationContext.SaveChanges();
        }
    }
}

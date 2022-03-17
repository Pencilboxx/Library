using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IPersoBookDetails
    {
        IList<PersoBooks> GetPersoBooks();
        PersoBooks GetPersoBooks(int bookid);
        void InsertBookIn(PersoBooks book);
        void UpdateBookIn(PersoBooks book);



    }
}

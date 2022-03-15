﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Model;
using RepositoryLayer;

namespace ServiceLayer
{
    public interface IBookDetails
    {
        IList<BookDetails> GetBookDetails();
        BookDetails GetBookDetails(int bid);
        void InsertBook(BookDetails book);
        void UpdateBook(BookDetails book);
        void DeleteBook(int id);


    }
}
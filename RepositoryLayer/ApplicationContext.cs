﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Model;

namespace RepositoryLayer
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions options):base(options)
        {

        }
        DbSet<BookDetails> BookDetails { get; set; }
        DbSet<PersonDetails> PersonDetails { get; set; }

      
    }
}

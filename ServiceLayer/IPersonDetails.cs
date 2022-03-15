﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Model;
using RepositoryLayer;

namespace ServiceLayer
{
    public interface IPersonDetails
    {
        IList<PersonDetails> GetPersonDetails();
        PersonDetails GetPersonDetails(int pid);
        void InsertPerson(PersonDetails person);
        void UpdatePerson(PersonDetails person);
        void DeletePerson(int id);
    }
}
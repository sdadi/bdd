using bdd.Core;
using bdd.Core.RepositoryInterfaces;
using System;
using System.Collections.Generic;

namespace bdd.Infrastructure.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPersons()
        {
            return new List<Person> { new Person { Id = 1, FirstName = "Satish", LastName = "DADI" } };
        }
    }
}
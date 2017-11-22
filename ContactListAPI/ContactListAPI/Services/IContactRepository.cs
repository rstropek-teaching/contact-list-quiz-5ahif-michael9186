using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactListAPI.Models;

namespace ContactListAPI.Services
{
    public interface IContactRepository
    {
        void AddPerson(Person p);
        IEnumerable<Person> GetAll();
        bool DeleteById(int id);
        IEnumerable<Person> FindByName(string name);
        Person GetLast();
        

    }
}

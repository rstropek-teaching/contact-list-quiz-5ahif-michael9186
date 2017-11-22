using ContactListAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactListAPI.Services
{
    public class ContactRepository : IContactRepository
    {
        private readonly List<Person> persons = new List<Person>()
        {
            new Person {id = 1, firstName = "Michael", lastName = "Schöller", email = "michael.schoeller98@gmx.at" },
            new Person {id = 2, firstName = "Fabian", lastName = "Maurhart", email ="fabian.maurhart@gmx.at" },
        };

        public void AddPerson(Person p)
        {
            persons.Add(p);
        }

        public IEnumerable<Person> GetAll()
        {
            return persons.ToArray();
        }

        public bool DeleteById(int id)
        {
            try
            {
                persons.RemoveAt(id - 1);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Person not found");               
            }
            return false;
            
        }

        public Person GetById(int id)
        {
            return persons.FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<Person> FindByName(string name)
        {
            List<Person> list = new List<Person>();

            foreach(Person p in this.persons)
            {
                if(p.firstName.Contains(name) || p.lastName.Contains(name))
                {
                    list.Add(p);
                }
            }
            return list;
            

        }

        public Person GetLast()
        {
            return this.persons.Last();
        }
    }
}

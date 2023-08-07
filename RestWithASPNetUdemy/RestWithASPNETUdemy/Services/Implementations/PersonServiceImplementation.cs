﻿using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
      
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for ( int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
           
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                id = IncrementAndGet(),
                FirstName = "Mika",
                LastName = "Carneiro",
                Adress = "Contagem - MG",
                Gender = "Feminino"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                id = IncrementAndGet(),
                FirstName = "PErson Name" + i,
                LastName = "Person LastName" + i,
                Adress = "Some Adrres" + i,
                Gender = "Female"
               
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}

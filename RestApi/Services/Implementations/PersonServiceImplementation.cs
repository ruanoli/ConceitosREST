using RestApi.Models;

namespace RestApi.Services.Implementations
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
            List<Person> people = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }
            return people;
        }

        public Person FindById(long i)
        {
            
            return new Person()
            {
                Id = 1,
                FirstName = "Person FirstName" + i,
                LastName = "Person LastName" + i,
                Adress = "Some Adress" + i,
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person()
            {
                Id = IncrmentAndGet(),
                FirstName = "Ruan",
                LastName = "Oliveira",
                Adress = "Ramos - Rio de Janeiro - Brasil",
                Gender = "Male"
            };
        }

        private long IncrmentAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}

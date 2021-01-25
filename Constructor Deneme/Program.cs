using System;

namespace Constructor_Deneme
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id = 1, FirstName = "Kasım", LastName = "Şahin", City = "İstanbul"};

            Customer customer2 = new Customer(3, "Ayşe", "Şahin", "İstanbul");

            Customer customer3 = new Customer();
            customer3.Id = 3;


            Console.WriteLine(customer.Id);
        }

    }
    class Customer
    {

        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
    
}

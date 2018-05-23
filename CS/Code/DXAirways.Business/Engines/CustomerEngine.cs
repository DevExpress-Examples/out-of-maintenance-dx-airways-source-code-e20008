using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DXAirways;
using DXAirways.Business.Orm;

namespace DXAirways.Business
{
    public class CustomerEngine : EngineBase
    {
        public CustomerEngine() : base() { }

        public CustomerEngine(Session session) : base(session) { }

        public Customer GetCustomerByEmail(string email)
        {
            Customer customer = null;

            CriteriaOperator criteria = new BinaryOperator("Email", email.ToLower(), BinaryOperatorType.Equal);
            customer = OrmFactory.GetEntity<Customer>(_Session, criteria);

            return customer;
        }

        public Customer GetCustomerByMilesNumber(string milesNumber)
        {
            Customer customer = null;

            CriteriaOperator criteria = new BinaryOperator("DxMilesNumber", milesNumber, BinaryOperatorType.Equal);
            customer = OrmFactory.GetEntity<Customer>(_Session, criteria);

            return customer;
        }

        public Customer GetCustomer(Guid customerId)
        {
            Customer customer = OrmFactory.GetEntity<Customer>(_Session, customerId);
            return customer;
        }

        public Customer CreateCustomer(string firstName, string lastName, string email, string password)
        {
            Customer customer = new Customer(_Session);
            
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Email = email;
            customer.Password = password;
            customer.Roles.Add(new Role("CUST"));
            customer.DxMilesNumber = GenerateNewMilesNumber();

            customer.Save();

            return customer;
        }

        public string GenerateNewMilesNumber()
        {
            Thread.Sleep(1);
            Random random = new Random(DateTime.Now.Millisecond);

            string firstLetter = char.ConvertFromUtf32(64 + GetRandomNumber(random, 25));
            string secondLetter = char.ConvertFromUtf32(64 + GetRandomNumber(random, 25));
            
            string milesNumber = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}",
                firstLetter, secondLetter, GetRandomNumber(random, 9), GetRandomNumber(random, 9),
                GetRandomNumber(random, 9), GetRandomNumber(random, 9), GetRandomNumber(random, 9), 
                GetRandomNumber(random, 9));

            return milesNumber;
        }

        private  int GetRandomNumber(Random random, int max)
        {
            int randomNumber = random.Next(0, max);

            return randomNumber;
        }
    }
}

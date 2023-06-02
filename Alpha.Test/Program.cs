using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using Alpha.API.Data;
using Alpha.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace Alpha.Test
{
    class Program
    {
        private static AlphaBaseContext _context = new AlphaBaseContext();

        private static void Main(string[] args)
        {
            //InsertNewUser();
            //EagerLoadUserWithEmail();
            //GetUserWithAddress();
            //AddNewAddressToUser();
            //AddNewEmailToUser();
            //AddNewPhoneToUser();
            //ReturnEmailWithUser();
            // ReturnAllEmailsWithUsers();
            //ReturnPhoneWithUser();
            // ReturnAllPhonesWithUsers();
            //ReturnUsersWithAddresses();
            // ReturnAllUsersWithAddresses();
            //RetrieveAndUpdateUser();
            //RetrieveAndUpdateAddress();
            //RetrieveAndUpdateEmailAddress();
            //RetrieveAndUpdatePhone();
            //RetrieveAndDeleteAUser();

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

        private static void InsertNewUser()
        {
            var user = new User
            {
                FirstName = "Larry",
                LastName = "Shepherd",
                Password = "Password1234!",
                EmailAddress = new List<EmailAddress>
                {
                    new EmailAddress { Email = "Larryshepherd1234@hotmail.com" }
                },
                Phones = new List<Phone>
                {
                    new Phone { PhoneNumber = "606-216-4444" }
                },
                Payments = new List<Payment>
                {
                    new Payment { PaymentId = 2 }
                },
                Address = new Address
                {
                    Address1 = "1461 Upper Second Creek Road",
                    CityTown = "Hazard",
                    StateProvince = "Kentucky",
                    PostalCode = "41701",
                    Country = "United States"
                }
            };
            _context.User.Add(user);
            _context.SaveChanges();
        }
        private static void EagerLoadUserWithEmail()
        {
            var filterPrimaryEntityWithInclude = _context.User
                                .Where(s => s.FirstName.Contains("Robert"))
                                .Include(s => s.EmailAddress).FirstOrDefault();
                               // .Include(s => s.Phone);
        }
        private static void GetUserWithAddress()
        {
            var user = _context.User.Include(s => s.Address).ToList();
        }
        private static void AddNewAddressToUser()
        {
            var user = _context.User.Find(3);
            user.Address = new Address
            {
                Address1 = "146 Sky Line Ln",
                CityTown = "Hazard",
                StateProvince = "Kentucky",
                PostalCode = "41701",
                Country = "United States"
            };
            _context.SaveChanges();
        }
        private static void AddNewEmailToUser()
        {
            var user = _context.User.Find(3);
            user.EmailAddress = new List<EmailAddress>
            {
                 new EmailAddress { Email = "Larryshepherd1234@hotmail.com" }
             };
            _context.SaveChanges();
        }
        private static void AddNewPhoneToUser()
        {
            var user = _context.User.Find(3);
            user.Phones = new List<Phone>
            {
                 new Phone { PhoneNumber = "606-216-4444" }
             };
            _context.SaveChanges();
        }
        private static void ReturnEmailWithUser()
        {
            var email = _context.EmailAddresses.Include(b => b.User).FirstOrDefault();
        }
        private static void ReturnAllEmailsWithUsers()
        {
            var email = _context.EmailAddresses.Include(b => b.User).ToList();
        }
        private static void ReturnPhoneWithUser()
        {
            var phone = _context.Phone.Include(b => b.User).FirstOrDefault();
        }
        private static void ReturnAllPhonesWithUsers()
        {
            var phone = _context.Phone.Include(b => b.User).ToList();
        }
        private static void ReturnUsersWithAddresses()
        {
            var user = _context.User.Include(b => b.Address).FirstOrDefault();
        }
        private static void ReturnAllUsersWithAddresses()
        {
            var user = _context.User.Include(b => b.Address).ToList();
        }
        private static void RetrieveAndUpdateUser()
        {
            var user = _context.User.Find(3);
            //user.FirstName = "Billy!";
            //user.LastName = "Kingsland!";
            user.Password = "Kingslayer1234!";
            _context.SaveChanges();
        }
        private static void RetrieveAndUpdateAddress()
        {
            var user = _context.User.Find(3);
            user.Address = new Address
            {
                Address1 = "200 Oakland St",
                CityTown = "Chavies",
                StateProvince = "Kentucky",
                PostalCode = "41719",
                Country = "United States"
            };

            _context.SaveChanges();
        }
        private static void RetrieveAndUpdateEmailAddress()
        {
            var email = _context.EmailAddresses.Find(3);
            email.Email = "Larrymanslayer@gmail.com";

            _context.SaveChanges();
        }
        private static void RetrieveAndUpdatePhone()
        {
            var phone = _context.Phone.Find(3);
            phone.PhoneNumber = "606-216-2255";

            _context.SaveChanges();
        }
        private static void RetrieveAndDeleteAUser()
        {
            var user = _context.User.Find(3);
            _context.User.Remove(user);
            _context.SaveChanges();
        }
    
    }
}
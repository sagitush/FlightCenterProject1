﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCenterProject
{
   public class LoggedInAdministratorFacade : AnonymousUserFacade, ILoggedInAdministratorFacade
    {
        /// <summary>
        /// Adds a airline company to the data base.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="airline"></param>
        public AirlineCompany CreateNewAirline(LoginToken<Administrator> token, AirlineCompany airline)
        {                     
           AirlineCompany airlineCompany= _airlineDAO.Add(airline);
            return airlineCompany;
        }

        /// <summary>
        /// Adds a Customer to the data base.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customer"></param>
        public void CreateNewCustomer(LoginToken<Administrator> token, Customer customer)
        {
            _customerDAO.Add(customer);
        }
        /// <summary>
        /// Get customer by Id
        /// </summary>
        /// <param name="token"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer GetCustomerById(LoginToken<Administrator> token, long id)
        {
           return _customerDAO.Get(id);
        }

        /// <summary>
        /// Removes a ailine company from the data base.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="airline"></param>
        public void RemoveAirline(LoginToken<Administrator> token, AirlineCompany airline)
        {
            _airlineDAO.Remove(airline);
            
        }

        /// <summary>
        /// Removes a customer from the data base.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customer"></param>
        public void RemoveCustomer(LoginToken<Administrator> token, Customer customer)
        {
            _customerDAO.Remove(customer);
        }

        /// <summary>
        /// Changes the details of the airline company.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="airline"></param>
        public void UpdateAirlineDetails(LoginToken<Administrator> token, AirlineCompany airline)
        {
            _airlineDAO.Update(airline);
        }

        /// <summary>
        /// Changes the details of the customer.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="customer"></param>
        public void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer)
        {
            _customerDAO.Update(customer);
        }
    }
}

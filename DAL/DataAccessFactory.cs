using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Customer, int, Customer> CustomerData()
        {
            return new CustomerRepo();
        }
        public static IRepo<Parcel, int, Parcel> ParcelData()
        {
            return new ParcelRepo();
        }
        public static IRepo<Driver, int, Driver> DriverData()
        {
            return new DriverRepo();
        }
        public static IRepo<Delivery, int, Delivery> DeliveryData()
        {
            return new DeliveryRepo();
        }
    }
}

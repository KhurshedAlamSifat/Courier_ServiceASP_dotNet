using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DriverRepo : Repo, IRepo<Driver, string, Driver>
    {
        public Driver Create(Driver obj)
        {
            db.Drivers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id); 
            db.Drivers.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Driver> GetAll()
        {
            return db.Drivers.ToList(); 
        }

        public Driver Read(string id)
        {
            return db.Drivers.Find(id);
        }

        public Driver Update(Driver obj)
        {
            var ex = Read(obj.Email);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if(db.SaveChanges()>0) return obj;
            else return null;   
        }
    }
}

using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ParcelRepo : Repo, IRepo<Parcel, string, Parcel>
    {
        public Parcel Create(Parcel obj)
        {
            db.Parcels.Add(obj);
            if(db.SaveChanges()>0) return obj;
            else return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Parcels.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Parcel> GetAll()
        {
            return db.Parcels.ToList();
        }

        public Parcel Read(string id)
        {
            return db.Parcels.Find(id);
        }

        public Parcel Update(Parcel obj)
        {
            var ex = Read(obj.Type);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            else return null;
        }
    }
}

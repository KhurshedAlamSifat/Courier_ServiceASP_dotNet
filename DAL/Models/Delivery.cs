using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Parcel")]
        public int ParcelID { get; set; }
        [ForeignKey("Driver")]
        public int DriverID { get; set; }
        public DateTime PickupDateTime { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public string Status { get; set; }
        public  string Route { get; set; }

        public virtual Parcel Parcel { get; set; }  
        public virtual Driver Driver { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Parcel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Weight { get; set; }
        [Required]
        public string Dimensions { get; set; }
        [Required]
        public string PickupAddress { get; set; }
        [Required]
        public string DestinationAddress { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string TrackingNumber { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }

        public Parcel() 
        {
            Deliveries = new List<Delivery>();
        }
    }
}

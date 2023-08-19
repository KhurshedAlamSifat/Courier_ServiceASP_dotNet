using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Availability { get; set; }

        public virtual ICollection<Delivery> Deliveries { get; set; }

        public Driver()
        {
            Deliveries= new List<Delivery>();
        }
    }
}

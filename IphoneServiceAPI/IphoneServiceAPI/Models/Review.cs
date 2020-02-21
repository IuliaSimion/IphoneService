using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IphoneServiceAPI.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReviewId { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public string Username { get; set; }
        public long ProductId { get; set; }
        public DateTime DatePosted { get; set; }

        public virtual Product Product { get; set; }
    }
}

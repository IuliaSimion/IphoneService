using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IphoneServiceAPI.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProductId { get; set; }
        public string Name { get; set; }
        public long CategorySubcategoryRelationId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public long? SaleId { get; set; }
        public decimal? NewPrice { get; set; }

        public virtual CategorySubcategoryRelation CategorySubcategoryRelation { get; set; }
        public virtual Sale Sale { get; set; }
    }
}

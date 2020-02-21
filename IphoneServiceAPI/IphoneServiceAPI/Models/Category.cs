using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IphoneServiceAPI.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<CategorySubcategoryRelation> CategorySubcategoryRelations { get; set; }
    }
}

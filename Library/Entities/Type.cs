using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    [Table("Types")]
   public class Type
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ProductOf")]
        public int Product_Id { get; set; }
        public virtual Dish ProductOf { get; set; }
    }
}

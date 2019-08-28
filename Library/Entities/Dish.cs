using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    [Table("Dishes")]
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Header { get; set; }
        [Required, MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public string Image_Name { get; set; }
    }
}

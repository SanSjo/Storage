using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Category { get; set; }
        [Range(1, 100)]
        public string Shelf { get; set; }
        [StringLength(200)]
        public string Description { get; set; }


    }
}

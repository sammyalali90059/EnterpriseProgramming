using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Item
    {
        [Key] //These attributes are for database generation
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set;}

        public double Price { get; set; }

        public string Description { get; set; }

        public string PhotoPath { get; set; }


    }
}

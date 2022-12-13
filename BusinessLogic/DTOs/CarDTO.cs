using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int ColorId { get; set; }
        public string? ColorName { get; set; }
        public decimal Price { get; set; }
        public double StoKMh { get; set; }
        public string? Description { get; set; }
        public string ImagePath { get; set; }
    }
}

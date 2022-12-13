using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public enum Colors : int
    {
        Black = 1,
        Yellow,
        Red,
        White,
        SpaceGray,
        Aqua,
        Gold,
        Gray,
        Lime,
        Silver
    }
    public class Color : IBaseEntity
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}

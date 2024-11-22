using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.DTO
{
    public class DtoProducto
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public decimal Price { get; set; }
    }
}

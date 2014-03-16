using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data.Entity;

namespace MvcPet.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateRecieved { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}
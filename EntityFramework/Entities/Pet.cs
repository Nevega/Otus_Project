using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    /// <summary>
    /// жЫвотное 
    /// </summary>
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PetStatus PetStatus { get; set; }
        public PetType PetType { get; set; }
        public DateTime PetStatusChange {  get; set; } = DateTime.Now;

    }
}

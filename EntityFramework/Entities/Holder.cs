using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    /// <summary>
    /// контейнеры (компании, места содержания животных и т.п)
    /// </summary>
    public class Holder
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Address { get; set; }
        public string ContactPerson   { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<HolderRoles> Roles { get; set; }
        public Holder Parent { get; set; }  
        public ICollection<Pet> Pets { get; set; }

    }
}

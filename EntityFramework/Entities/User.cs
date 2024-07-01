using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    /// <summary>
    /// Физическое лицо
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<HolderUser> HolderUsers { get; set; }
        public ICollection<Contact> Contacts { get; set; }


    }
}

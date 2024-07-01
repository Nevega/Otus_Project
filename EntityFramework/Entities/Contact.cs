using EntityFramework.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    /// <summary>
    /// контакты (телефон, сайт ...)
    /// </summary>
    public class Contact
    {
        public int Id { get; set; }
        public ContactType ContactType { get; set; }
        public string Info { get; set; } = string.Empty;
    }
}

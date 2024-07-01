using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    /// <summary>
    /// статус (пристроено, на передержке, в розыске ...)
    /// </summary>
    public class PetStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}

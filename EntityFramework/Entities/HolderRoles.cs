using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    /// <summary>
    /// Набор ролей для контейнера (спонсор, приют и т.п)
    /// </summary>
    public class HolderRoles
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

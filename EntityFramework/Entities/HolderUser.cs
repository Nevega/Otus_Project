using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Entities
{
    /// <summary>
    /// Связка контейнера с пользователем (с указанием роли)
    /// </summary>
    public class HolderUser
    {
        public Holder Holder { get; set; }
        public User User  { get; set; }
        public UserRole Role { get; set; }
    }
}

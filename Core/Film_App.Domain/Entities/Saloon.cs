using Film_App.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_App.Domain.Entities
{
    public class Saloon : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}

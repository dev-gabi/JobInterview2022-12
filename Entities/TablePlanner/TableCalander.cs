using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.TablePlanner
{
    public class TableCalander
    {
        public DateTime Date { get; set; }
        public Table Table { get; set; }
        public bool IsBooked { get; set; }
    }
}

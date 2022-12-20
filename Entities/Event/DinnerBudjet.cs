using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Event
{
    public class DinnerBudjet
    {
        public string DinnerId { get; set; }
        public int BudjetPerEmployee { get; set; }
        public int Budjet { get; set; }

        public int GetTotalBudjet(int employeeNum)
        {
            return BudjetPerEmployee * employeeNum + Budjet;
        }
    }
}

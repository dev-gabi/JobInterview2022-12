using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class TablePlannerService : ITablePlannerService
{

    static Table[] Tables = new Table[]
{
            new Table(){ Id = 1, Seats = 3},
            new Table(){ Id = 2, Seats = 4},
            new Table(){ Id = 2, Seats = 6},
};
    List<TableCalander> Calander = new List<TableCalander>
         {
             new TableCalander(){ Date = DateTime.Now, Table = Tables[0], IsBooked = false },
             new TableCalander(){ Date = DateTime.Now, Table = Tables[1],  IsBooked = true },
             new TableCalander(){ Date = DateTime.Now, Table = Tables[2],  IsBooked = false },
        };

    public bool CheckTableAvailabilty(int guestNum, DateTime date)
    {
         return Calander.Where(t => t.Date.Date == date.Date && t.IsBooked == false && t.Table.Seats >= guestNum ).ToList().Count() > 0;

    }
}

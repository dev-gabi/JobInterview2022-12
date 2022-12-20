using DAL;
using Entities.TablePlanner;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public interface IDatePlannerService
    {
        bool CheckTableAvailabilty(int guestNum, DateTime date);
    }

    public class DatePlannerService : IDatePlannerService
    {


        public bool CheckTableAvailabilty(int guestNum, DateTime date)
        {
            DinnerEventDal dal = new DinnerEventDal();
            if (dal.IsTableFreeByDate(date))
            {
               return dal.GetFreeTablesByGuestNum(guestNum, date).Count() > 0;
            }

            return false;          
        }
    }
}

using DAL;
using Entities;
using System;
using System.Collections.Generic;
using TablePlannerService;

namespace BL
{
    public class DinnerLogic
    {
        readonly DinnerEventDal dal = new DinnerEventDal();

        public List<DinnerEvent> GetAllDinnerEvents()
        {          
            return dal.GetAllEvents();
        }
        public DinnerEvent GetDinnerEventById(int id)
        {    

            return dal.GetDinnerEventById(id);
        }

        public List<DinnerEvent>  GetDinnerEventsByEmployee(string id)
        {
            return dal.GetEventsByEmployee(id);
        }

        public void AddNewDinnerEvent(DinnerEvent dinnerEvent)
        {
            bool IsTable = IsTableAvailable(dinnerEvent.Participents.Count, DateTime.Now);
            if (IsTable)
            {
                dal.AddNewDinnerEvent(dinnerEvent);
            }          
        }

        public bool EditDinnerEvent(DinnerEvent dinnerEvent)
        {
            return dal.EditDinnerEvent(dinnerEvent);
        }

        public bool DeleteDinnerEvent(int id)
        {
           return dal.DeleteDinnerEvent(id);
        }

        public bool IsTableAvailable(int guestNum, DateTime date)
        {
            TablePlannerServiceClient client = new TablePlannerServiceClient();
            return client.CheckTableAvailabiltyAsync(guestNum, date).Result;
        }
    }
}

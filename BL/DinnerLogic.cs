using DAL;
using Entities;
using System;
using System.Collections.Generic;

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

        public List<DinnerEvent>  GetDinnerEventsByemployee(string id)
        {
            return dal.GetEventsByEmployee(id);
        }

        public void AddNewDinnerEvent(DinnerEvent dinnerEvent)
        {
            dal.AddNewDinnerEvent(dinnerEvent);
        }

        public bool EditDinnerEvent(DinnerEvent dinnerEvent)
        {
            return dal.EditDinnerEvent(dinnerEvent);
        }

        public bool DeleteDinnerEvent(int id)
        {
           return dal.DeleteDinnerEvent(id);
        }
    }
}

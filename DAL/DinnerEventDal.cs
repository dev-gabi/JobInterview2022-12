using Entities;
using Entities.Employees;
using Entities.Event;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DinnerEventDal
    {
        static Employee[] Employees = new Employee[]
{
                            new Employee { Id = "aaa123", FirstName="bob", LastName="yelp"},
                            new Employee { Id = "bbb123", FirstName="ron", LastName="lotz"},
                            new Employee { Id = "cc12a", FirstName="jasmine", LastName="mor"},
};
        List<DinnerEvent> Events = new List<DinnerEvent>();


        public DinnerEventDal()
        {
           Events = new List<DinnerEvent> {
                new DinnerEvent(){
                    Id= 1,
                    Name="Low cost",
                    Address="apple road",
                    Budjet = new DinnerBudjet(){ Budjet = 100, BudjetPerEmployee = 50, DinnerId = "abcd" },
                    Participents = new List<Employee>{
                           Employees[0],
                           Employees[1]
                    } },

                   new DinnerEvent(){
                    Id= 2,
                    Name="Fancy",
                    Address="diamond road",
                    Budjet = new DinnerBudjet(){ Budjet = 1000, BudjetPerEmployee = 20, DinnerId = "fancyr" },
                    Participents = new List<Employee>{
                       Employees[1],
                       Employees[2]
                    } },

            };
        }
    

        public List<DinnerEvent> GetAllEvents()
        {
            return Events;
        }

        public DinnerEvent GetDinnerEventById(int id)
        {
            return Events.Where(e => e.Id == id).FirstOrDefault();
        }

        public void AddNewDinnerEvent(DinnerEvent dinnerEvent)
        {
            this.Events.Add(dinnerEvent);
        }

        public List<DinnerEvent> GetEventsByEmployee(string id)
        {
            Employee emp = Employees.ToList().Find(e => e.Id == id);
            return Events.Where(e => e.Participents.Contains(emp)).ToList();
        }
        public bool EditDinnerEvent(DinnerEvent dinnerEvent)
        {
            int index = Events.FindIndex(e => e.Id == dinnerEvent.Id);
            if (index != -1)
            {
                Events[index] = dinnerEvent;
                return true;
            }
            return false;
        }

        public bool DeleteDinnerEvent(int id)
        {
            DinnerEvent d = Events.Where(e => e.Id == id).FirstOrDefault();
            Events.Remove(d);
            return Events.FindIndex(e => e.Id == id) == -1 ? true : false;
        }

    }
}

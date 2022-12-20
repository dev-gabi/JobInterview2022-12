using Entities.Employees;
using Entities.Event;
using System;
using System.Collections.Generic;

namespace Entities
{
    public class DinnerEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Employee> Participents { get; set; }
        public DinnerBudjet Budjet { get; set; }
    }
}

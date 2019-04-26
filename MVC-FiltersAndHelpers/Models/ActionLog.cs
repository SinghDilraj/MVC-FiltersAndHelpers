using System;

namespace MVC_FiltersAndHelpers.Models
{
    public class ActionLog
    {
        public int Id { get; set; }
        public long ExecutionTime { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
    }
}
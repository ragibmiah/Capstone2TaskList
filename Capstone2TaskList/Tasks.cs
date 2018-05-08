using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone2TaskList
{
    class Tasks
    {
        public string TaskOwner { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public bool complete { get; set; }

        public Tasks(bool Complete, double days, string taskOwner, string taskName)
        {
            TaskOwner = taskOwner;
            TaskName = taskName;
            DueDate = DateTime.Now.AddDays(days);
            bool complete = false;
        }
    }
}

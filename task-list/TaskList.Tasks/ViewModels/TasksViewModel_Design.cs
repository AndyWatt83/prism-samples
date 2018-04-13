using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Tasks
{
    class TasksViewModel_Design : ITasksViewModel
    {
        public string SomeText {
            get
            {
                return "Tasks Design VM text";
            }
            set { }
        }

        public string ClickCounter
        {
            get
            {
                return "Button has been clicked 42 times";
            }
            set { }
        }

    }
}

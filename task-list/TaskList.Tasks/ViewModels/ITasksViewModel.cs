using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Tasks
{
    public interface ITasksViewModel
    {
        string SomeText { get; set; }
        string ClickCounter { get; set; }
    }
}

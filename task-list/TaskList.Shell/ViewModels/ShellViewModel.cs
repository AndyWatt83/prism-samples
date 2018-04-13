using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Shell 
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ShellViewModel : BindableBase, IShellViewModel
    {
        public ShellViewModel()
        {
            SomeText = "Auto-wireup VM Test";
        }

        public string SomeText { get; set; }
    }
}

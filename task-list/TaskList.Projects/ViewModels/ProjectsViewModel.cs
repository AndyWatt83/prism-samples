using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Events;

namespace TaskList.Projects
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ProjectsViewModel : BindableBase, IProjectsViewModel
    {
        IEventAggregator _EventAggregator;

        [ImportingConstructor]
        public ProjectsViewModel(IEventAggregator ea)
        {
            _EventAggregator = ea;
            SomeText = "Auto-wireup VM Test";

            ButtonHasBeenClickedCommand = new DelegateCommand(ButtonHasBeenClicked);
        }

        public string SomeText { get; set; }

        public DelegateCommand ButtonHasBeenClickedCommand { get; private set; }

        private void ButtonHasBeenClicked()
        {
            _EventAggregator.GetEvent<SimpleMessageEvent>().Publish(0);
        }

    }
}

using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Events;

namespace TaskList.Tasks
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class TasksViewModel : BindableBase, ITasksViewModel, IPartImportsSatisfiedNotification
    {
        private int _clickCounter;

        public TasksViewModel()
        {
            SomeText = "Tasks Auto-wireup VM Test";
        }

        [Import(typeof(IEventAggregator))]
        public IEventAggregator EventAggregator { get; set;}

        public string ClickCounter { get { return $"Button has been clicked {_clickCounter} times"; } set { } }

        public string SomeText { get; set; }

        public void OnImportsSatisfied()
        {
            EventAggregator.GetEvent<SimpleMessageEvent>().Subscribe(ButtonHasBeenClickedReceived);
        }

        private void ButtonHasBeenClickedReceived(int i)
        {
            _clickCounter++;
            //OnPropertyChanged(() => this.ClickCounter); //this is the old way of doing this..
            RaisePropertyChanged(nameof(ClickCounter));
        }
    }
}

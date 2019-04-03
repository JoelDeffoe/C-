using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoList.Controller;

namespace TodoList.View
{
    class TaskListeView : INotifyPropertyChanged
    {
        private ObservableCollection<TaskView> tasks = new ObservableCollection<TaskView>();
        public ObservableCollection<TaskView>Tasks
        {
            get { return tasks; }
            set {
                if (tasks != value)
                {
                    tasks = value;
                    NotifyPropertyChanged(nameof(Tasks));
                }
            }
        }
        public string TaskName { get; set; }
        public ICommand CreatCommand { get { return new CreatCommand(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged( string name )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

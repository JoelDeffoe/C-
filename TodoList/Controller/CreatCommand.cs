using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TodoList.View;

namespace TodoList.Controller
{
    class CreatCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is TaskListeView taskListe)
            {
                taskListe.Tasks.Add(new TaskView() { Name = taskListe.TaskName, IsDone = false });
            }
        }
    }
}

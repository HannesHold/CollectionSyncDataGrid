using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSyncDataGrid.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Constructors

        public MainWindowViewModel()
        {
            Students = new ObservableCollection<StudentViewModel>();
            Students.Add(new StudentViewModel("Alfred Judokus Quack", 23, "Hehehe"));
            Students.Add(new StudentViewModel("Jack Reacher", 55, "Cool guy"));
            Students.Add(new StudentViewModel("Catherine Cathuka", 11, "Just a kid man"));
            Students.Add(new StudentViewModel("Arnold Schwarzenegger", 66, "I'll be back"));
            Students.Add(new StudentViewModel("Clint Eastwood", 99, "Old but gold"));
        }

        #endregion

        #region Properties

        private ObservableCollection<StudentViewModel> _students;

        public ObservableCollection<StudentViewModel> Students
        {
            get { return _students; }
            set { _students = value; OnPropertyChanged(); }
        }

        private StudentViewModel _selectedStudent;

        public StudentViewModel SelectedStudent
        {
            get { return _selectedStudent; }
            set { _selectedStudent = value; OnPropertyChanged(); }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

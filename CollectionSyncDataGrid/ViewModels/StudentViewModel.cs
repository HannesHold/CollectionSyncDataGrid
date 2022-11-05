using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSyncDataGrid.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        #region Constructors

        public StudentViewModel(string name, int age, string remark)
        {
            Name = name;
            Age = age;
            Remark = remark;
        }

        #endregion

        #region Properties

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged(); }
        }

        private string _remark;

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; OnPropertyChanged(); }
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

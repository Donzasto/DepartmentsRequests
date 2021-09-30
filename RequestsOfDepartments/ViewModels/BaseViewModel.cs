using System.Collections.Generic;
using System.ComponentModel;

namespace DepartmentsRequests.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string ShortName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

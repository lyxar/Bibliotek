using GalaSoft.MvvmLight;
using System.ComponentModel;

namespace Bibliotek.ViewModel
{
    //Base ViewModel used for the propertychanged event
    public class BaseViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

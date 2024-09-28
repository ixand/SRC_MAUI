using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace WidgetBoard.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void ONPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    protected bool SetProperty<TValue>(ref TValue backingField, TValue value, [CallerMemberName] string propertyName = "")
        {
            if(Comparer<TValue>.Default.Compare(backingField,value) == 0)
            {
                return false;
            }

            backingField = value;

            ONPropertyChanged(propertyName);
            return true;
        }
    }
}

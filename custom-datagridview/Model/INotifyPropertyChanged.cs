namespace custom_datagridview.model
{

    public delegate void PropertyChangedDelegate(string propertyName);

    public interface INotifyPropertyChanged
    {
        event PropertyChangedDelegate PropertyChanged;
    }

}

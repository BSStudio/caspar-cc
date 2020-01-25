using System.Collections;

namespace custom_datagridview.model
{

    public delegate void ObservableListItemsChangedDelegate();

    public interface IObservableList: IEnumerable
    {
        event ObservableListItemsChangedDelegate ItemsChanged;
        int Count { get; }
    }

}

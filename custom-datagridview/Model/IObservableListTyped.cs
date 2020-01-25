using System.Collections.Generic;

namespace custom_datagridview.model
{

    public interface IObservableList<T> : IObservableList, IEnumerable<T>
    {
        T this[int index] { get; }
    }

}

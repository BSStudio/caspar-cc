namespace custom_datagridview
{

    abstract class CustomDataGridViewComboBoxItem<T>
        where T : class
    {

        public T Value { get; private set; }

        public string Label { get => ToString(); }

        public CustomDataGridViewComboBoxItem(T value)
        {
            Value = value;
        }

        public class NullItem : CustomDataGridViewComboBoxItem<T>
        {

            private string label;

            public NullItem(string label) : base(null)
            {
                this.label = label;
            }

            public override string ToString()
            {
                return label;
            }

        }

    }

}

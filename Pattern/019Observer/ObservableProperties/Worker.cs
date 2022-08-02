using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ObservableProperties
{
    #region NotifyCollection

    //class Col : INotifyCollectionChanged
    //{
    //    public event NotifyCollectionChangedEventHandler CollectionChanged;
    //}

    #endregion

    public class Worker : INotifyPropertyChanged
    {
        private int age;
        private string name;
        private int salary;

        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(); }
        }
        public int Age
        {
            get => age;
            set { if (age == value) return; age = value; OnPropertyChanged(); }
        }
        public int Salary
        {
            get => salary;
            set { salary = value; OnPropertyChanged(); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
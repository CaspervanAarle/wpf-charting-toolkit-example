using System.Windows.Input;
using System.ComponentModel;
using System.Collections.Generic;
using Visualization_I4_test.Model;

class UserViewModel
{
    private IList<User> _UsersList;

    public UserViewModel()
    {
        _UsersList = new List<User>
        {
            new User { UserId = 1, Name = "Raj", LastName = "Beniwal", City = "Delhi", State = "DEL", Country = "INDIA", Age=42 },
            new User { UserId = 2, Name = "Mark", LastName = "henry", City = "New York", State = "NY", Country = "USA", Age=7 },
            new User { UserId = 3, Name = "Mahesh", LastName = "Chand", City = "Philadelphia", State = "PHL", Country = "USA", Age=87 },
            new User { UserId = 4, Name = "Vikash", LastName = "Nanda", City = "Noida", State = "UP", Country = "INDIA", Age=89 },
            new User { UserId = 5, Name = "Harsh", LastName = "Kumar", City = "Ghaziabad", State = "UP", Country = "INDIA", Age=17 },
            new User { UserId = 6, Name = "Reetesh", LastName = "Tomar", City = "Mumbai", State = "MP", Country = "INDIA", Age=31 },
            new User { UserId = 7, Name = "Deven", LastName = "Verma", City = "Palwal", State = "HP", Country = "INDIA", Age=33 },
            new User { UserId = 8, Name = "Ravi", LastName = "Taneja", City = "Delhi", State = "DEL", Country = "INDIA", Age=73 }
        };
    }

    public IList<User> Users
    {
        get { return _UsersList; }
        set { _UsersList = value; }
    }

    private ICommand mUpdater;

    public ICommand UpdateCommand
    {
        get
        {
            if (mUpdater == null)
                mUpdater = new Updater();
            return mUpdater;
        }
        set
        {
            mUpdater = value;
        }
    }

    private class Updater : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            // Code implementation for execution
        }
    }
}
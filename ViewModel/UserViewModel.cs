using SimpleMvvmPatternInWpf.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleMvvmPatternInWpf.ViewModel
{
    public class UserViewModel
    {
        private List<User> _users = new List<User>();
        public UserViewModel()
        {
            _users = GetInitialUsers();
        }

        private List<User> GetInitialUsers()
        {
            return new List<User>()
            {
                new User() {UserId = 1, FullName = "Ngô Trọng Phong", Email = "phong@gmail.com", PhoneNumber = "0123999999", Address = "Hải Dương"},
                new User() {UserId = 2, FullName = "Nguyễn Thị Bình", Email = "binh@gmail.com", PhoneNumber = "0123888888", Address = "Hà Nội"},
                new User() {UserId = 3, FullName = "Ngô Minh Châu", Email = "minhchau@gmail.com", PhoneNumber = "0123777777", Address = "Hải Dương"},
            };
        }

        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        private ICommand updateStatus;

        public ICommand UpdateCommand
        {
            get
            {
                if (updateStatus == null)
                    updateStatus = new Updater();
                return updateStatus;
            }

            set
            {
                updateStatus = value;
            }
        }

        private class Updater : ICommand
        {
            public bool CanExecute(object parameter) => true;

            public event EventHandler? CanExecuteChanged;

            public void Execute(object? parameter)
            {
                throw new NotImplementedException();
            }
        }
    }
}

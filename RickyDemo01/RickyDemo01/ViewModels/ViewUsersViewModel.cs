using RickyDemo01.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RickyDemo01.ViewModels
{
    class ViewUsersViewModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private readonly IRickyRipository _repo;
        private IEnumerable<AlphaUser> _users;

        public IEnumerable<AlphaUser> Users
        {
            get { return _users; }
            set {
                _users = value;
                OnPropertyChanged();

            }
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public ViewUsersViewModel()
        {
            
        }

        public ViewUsersViewModel(IRickyRipository Repo)
        {
            _repo = Repo;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand RefreshCommand
        {
            get { return new Command(async () => { Users = await _repo.GetUsersAsync(); }); }

        }
        public ICommand AddCommand
        {
            get { return new Command(async () => { var user = new AlphaUser { UserName = Username, Email = Password };
                await _repo.AddUserAsync(user);
             
            }); }

        }

    }
}

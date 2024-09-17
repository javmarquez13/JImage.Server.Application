using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using JImage.Server.ViewModels.ViewModels.Admin.DTOs;

namespace JImage.Server.ViewModels.ViewModels.Admin.FormFields
{
    public class AdminFormFields : ObservableObject
    {
        private UserDto _SelectedUser; 
        public UserDto SelectedUser
        {
            get=> _SelectedUser;
            set=> SetProperty(ref _SelectedUser, value);
        }

        private string _SelectedPassword;
        public string SelectedPassword
        {
            get => _SelectedPassword;
            set => SetProperty(ref _SelectedPassword, value);
        }
    }
}

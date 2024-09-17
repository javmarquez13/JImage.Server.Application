using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JImage.Server.ViewModels.ViewModels.Base;


using JImage.Server.ViewModels.ViewModels.Admin.DTOs;
using JImage.Server.ViewModels.ViewModels.Admin.FormFields;

namespace JImage.Server.ViewModels.ViewModels.Admin
{
    public class AdminViewModel : BaseViewModel
    {
        public AdminViewModel() 
        {
        
        }


        private AdminFormFields form = new AdminFormFields();
        public AdminFormFields Form
        {
            get=> form;
            set=> SetProperty(ref form, value);
        }

        private List<UserDto> _UsersCatalog;
        public List<UserDto> UsersCatalog
        {
            get => _UsersCatalog;
            set => SetProperty(ref _UsersCatalog, value);
        }


        public async Task LoadCatalogs()
        {
            IsBusy = true;
            try
            {
                await this.LoadUserCatalogAsync();
            }
            catch (Exception ex)
            {
                SendErrorMessage(
                    $"Catalogs were not loaded correctly {ex.Message}");
            }
            finally
            {
                IsBusy = false;
            }
        }


        public async Task LoadUserCatalogAsync()
        {
            //DataDummie
            this._UsersCatalog = new List<UserDto>();
            this._UsersCatalog.AddRange(new List<UserDto> {
                                 new UserDto { Id=1, Name = "Javier Marquez", Rol="Administrador" },
                                 new UserDto { Id=2, Name = "Miguel Derma", Rol="Test Enginner IV" }
            });

            UsersCatalog = this._UsersCatalog;
            await Task.Delay(2500);
        }



        public async Task<bool> LoginCommand()
        {
            IsBusy = true;
            try
            {
                var selectedUser = Form.SelectedUser;
                var selectedPassowrd = Form.SelectedPassword;
                
                await Task.Delay(2000);
                return true;
            }
            catch (Exception ex)
            {
                SendErrorMessage(
                    $"Login failed {ex.Message}");

                return false;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

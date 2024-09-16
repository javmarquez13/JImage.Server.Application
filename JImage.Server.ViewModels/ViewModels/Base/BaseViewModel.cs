using System;
using JImage.Server.ViewModels.Helpers;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;

namespace JImage.Server.ViewModels.ViewModels.Base
{
    public partial class BaseViewModel : ObservableObject
    {
        private bool isBusy = false;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        public event EventHandler<MessageEventArgs> ErrorMessageWasSent;
        public event EventHandler<MessageEventArgs> SuccessMessageWasSent;
        public void SendErrorMessage(string message)
        {
            ErrorMessageWasSent?.Invoke(this, new MessageEventArgs(message));
        }

        public void SendSuccessMessage(string message)
        {
            SuccessMessageWasSent?.Invoke(this, new MessageEventArgs(message));
        }


        public event EventHandler<MessageEventArgs> SuccessfullySubmitted;
        public event EventHandler<MessageEventArgs> CriticalFailiureHasOcurred;

        public void FireSuccessfullySubmitted(string SuccessMessage = null)
        {
            SuccessfullySubmitted?.Invoke(this, new MessageEventArgs(SuccessMessage));
        }

        public void FireCriticalFailiureHasOcurred(string message)
        {
            CriticalFailiureHasOcurred?.Invoke(this, new MessageEventArgs(message));
        }
    }
}

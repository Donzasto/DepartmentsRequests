using DepartmentsRequests.DAL;
using DepartmentsRequests.Models;
using DepartmentsRequests.ViewModels;
using System;
using System.Windows.Input;

namespace DepartmentsRequests.Commands
{
    internal class AddRequestCommand : ICommand
    {
        private readonly RequestViewModel _requestViewModel;

        public AddRequestCommand(RequestViewModel requestViewModel)
        {
            _requestViewModel = requestViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            using DepartmentsRequestsContext departmentsRequestsContext = new();

            departmentsRequestsContext.Add(new OGMehRequestModel()
            {
                Equipment = _requestViewModel.Equipment,
                Department = _requestViewModel.Department,
                FullNameSender = _requestViewModel.FullNameSender,
                Specialist = _requestViewModel.Specialist,
                Order = _requestViewModel.Order,
                MailSender = _requestViewModel.MailSender,
                PhoneSender = _requestViewModel.PhoneSender,
                Description = _requestViewModel.Description,
                FullNameOperator = _requestViewModel.FullNameOperator,
                DateProvide = _requestViewModel.DateProvide
                });

            departmentsRequestsContext.SaveChanges();
        }
    }
}

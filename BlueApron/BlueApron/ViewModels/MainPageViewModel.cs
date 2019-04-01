using BlueApron.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BlueApron.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Commands
        public ICommand OnLoginCommand { get; private set; }
        public ICommand OnDeliverFormCommand { get; private set; }
        public ICommand OnSelectPlanCommand { get; private set; }
        public ICommand OnSignUpCommand { get; private set; }
        public ICommand OnOrderSummaryCommand { get; private set; }
        public ICommand OnFoodWeekCommand { get; private set; }
        #endregion

        public MainPageViewModel()
        {
            OnLoginCommand = new Command(() => OnNavigateToPage(new LoginPage()));
            OnDeliverFormCommand = new Command(() => OnNavigateToPage(new DeliverFormPage()));
            OnSelectPlanCommand = new Command(() => OnNavigateToPage(new SelectPlanPage()));
            OnSignUpCommand = new Command(() => OnNavigateToPage(new SignUpPage()));
            OnOrderSummaryCommand = new Command(() => OnNavigateToPage(new OrderSummaryPage()));
            OnFoodWeekCommand = new Command(() => OnNavigateToPage(new FoodWeekPage()));

            
        }

        /// <summary>
        /// Navigate to page
        /// </summary>
        /// <param name="page"></param>
        void OnNavigateToPage(Page page) =>
            Application.Current.MainPage.Navigation.PushAsync(page);
    }
}

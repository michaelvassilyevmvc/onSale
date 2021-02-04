using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OnSale.Common.Enitities;
using OnSale.Common.Responses;
using OnSale.Common.Services;
using Prism.Navigation;
using Xamarin.Essentials;

namespace OnSale.Prism.ViewModels
{
    public class ProductsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;
        private ObservableCollection<Product> _products;


        public ObservableCollection<Product> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }

        public ProductsPageViewModel(INavigationService navigationService,IApiService apiService):base(navigationService)
        {
            _navigationService = navigationService;
            _apiService = apiService;
            Title = "Product";
            LoadProductsAsync();
        }

        private async void LoadProductsAsync()
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await App.Current.MainPage.DisplayAlert("Ошибка", "Проверьте подключение к Интернету.", "Принять");
                return;
            }

            string url = App.Current.Resources["UrlAPI"].ToString();
            Response response = await _apiService.GetListAsync<Product>(
                url,
                "/api",
                "/Products");

            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert(
                    "Ошибка",
                    response.Message,
                    "Принять");
                return;
            }

            List<Product> myProducts = (List<Product>)response.Result;
            Products = new ObservableCollection<Product>(myProducts);
        }
    }
}

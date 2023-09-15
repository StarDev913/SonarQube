﻿using eShopOnContainers.Services;
using eShopOnContainers.Views;

namespace eShopOnContainers;

public partial class AppShell : Shell
{
    private readonly INavigationService _navigationService;

    public AppShell(INavigationService navigationService)
    {
        _navigationService = navigationService;

        AppShell.InitializeRouting();
        InitializeComponent();
    }

    protected override async void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        if (Handler is not null)
        {
            await _navigationService.InitializeAsync();
        }
    }

    private static void InitializeRouting()
    {
        Routing.RegisterRoute("Filter", typeof(FiltersView));
        Routing.RegisterRoute("Basket", typeof(BasketView));
        Routing.RegisterRoute("Basket", typeof(BasketView));
        Routing.RegisterRoute("Settings", typeof(SettingsView));
        Routing.RegisterRoute("OrderDetail", typeof(OrderDetailView));
        Routing.RegisterRoute("CampaignDetails", typeof(CampaignDetailsView));
        Routing.RegisterRoute("Checkout", typeof(CheckoutView));
    }
}
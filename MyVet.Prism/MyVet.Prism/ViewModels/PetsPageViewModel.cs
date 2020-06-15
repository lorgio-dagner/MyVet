﻿using MyVet.Common.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyVet.Prism.ViewModels
{
    // Aqui Cambiamos "BindableBase" por ViewModelBase este cmabio se hace a todas la ViewModel
    public class PetsPageViewModel : ViewModelBase
    {
        private OwnerResponse _owner;
        private ObservableCollection<PetResponse> _pets;


        // y al heredar de la ViewModelBase necesitamos inyectar el INavigationServer
        public PetsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Pets";

        }
        public ObservableCollection<PetResponse> Pets
        {
            get => _pets;
            set => SetProperty(ref _pets, value);

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if(parameters.ContainsKey("owner"))
            {
                _owner = parameters.GetValue<OwnerResponse>("owner");
                Title = $"Pets of: {_owner.FullName}";
                Pets = new ObservableCollection<PetResponse>(_owner.Pets);

            }
        }
    }
}

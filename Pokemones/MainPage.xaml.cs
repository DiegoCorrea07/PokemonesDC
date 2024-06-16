﻿using Pokemones.Models;
using Pokemones.Services;

namespace Pokemones
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            CargarData();
        }

        public async void CargarData()
        {
            PokemonServices poke_services = new PokemonServices();
            var listado_pokemones = await poke_services.DevuelveListadoPokemones();

            ListaPokemones.ItemsSource = listado_pokemones;
        }
        public async void VerInfoPokemon(object sender, SelectedItemChangedEventArgs e)
        {
            PokemonInfo poke_info = (PokemonInfo)e.SelectedItem;
            Navigation.PushAsync(new ResumenPokemon(poke_info));
        }

    }

}
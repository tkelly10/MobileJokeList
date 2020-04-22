using System;
using System.Collections.Generic;
using JokeDB.Models;
using Xamarin.Forms;

namespace JokeDB.Views
{
    public partial class JokeItemPage : ContentPage
    {
        public JokeItemPage()
        {
            InitializeComponent();
        }

        async void JokeSave(object sender, EventArgs e)
        {
            var jokeItem = (JokeItem)BindingContext;
            await App.Database.SaveItemAsync(jokeItem);
            await Navigation.PopAsync();
        }

        async void JokeDelete(object sender, EventArgs e)
        {
            var jokeItem = (JokeItem)BindingContext;
            await App.Database.DeleteItemAsync(jokeItem);
            await Navigation.PopAsync();
        }

        async void JokeCancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

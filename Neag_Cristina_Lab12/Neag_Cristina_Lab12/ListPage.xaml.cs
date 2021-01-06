using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neag_Cristina_Lab12.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Neag_Cristina_Lab12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShoppingList)BindingContext;
            slist.Date = DateTime.UtcNow;
            await App.Database.SaveShoppingListAsync(slist);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (ShoppingList)BindingContext;
            await App.Database.DeleteShoppingListAsync(slist);
            await Navigation.PopAsync();
        }
    }
}
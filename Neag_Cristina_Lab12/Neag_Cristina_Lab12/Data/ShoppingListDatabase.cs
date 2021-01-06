using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Neag_Cristina_Lab12.Models;

namespace Neag_Cristina_Lab12.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService;
        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
        }
        public Task<List<ShoppingList>> GetShoppingListsAsync()
        {
            return restService.RefreshDataAsync();
        }
        public Task SaveShoppingListAsync(ShoppingList item, bool isNewItem = true)
        {
            return restService.SaveShoppingListAsync(item, isNewItem);
        }
        public Task DeleteShoppingListAsync(ShoppingList item)
        {
            return restService.DeleteShoppingListAsync(item.ID);
        }
    }
}


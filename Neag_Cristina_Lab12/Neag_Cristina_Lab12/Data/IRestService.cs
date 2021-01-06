using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Neag_Cristina_Lab12.Models;

namespace Neag_Cristina_Lab12.Data
{
    public interface IRestService
    {
        Task<List<ShoppingList>> RefreshDataAsync();
        Task SaveShoppingListAsync(ShoppingList item, bool isNewItem);
        Task DeleteShoppingListAsync(int id);
    }
}

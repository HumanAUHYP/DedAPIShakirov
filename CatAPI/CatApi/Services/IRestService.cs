using DedApi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DedApi.Services
{
    public interface IRestService
    {
        Task<List<Cat>> GetCatsAsync();
        Task SaveCatAsync(Cat cat, bool isNewItem);
        Task DeleteCatAsync(Cat cat);
    }
}

using DedApi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DedApi.Services
{
    public class RequestManager
    {
        IRestService restService;
        public RequestManager(IRestService service)
        {
            restService = service;
        }

        public Task<List<Cat>> GetCats()
        {
            return restService.GetCatsAsync();
        }

        public Task DeleteCatAsync(Cat cat)
        {
            return restService.DeleteCatAsync(cat);
        }

        public Task SaveCatAsync(Cat cat, bool isNewItem = false)
        {
            return restService.SaveCatAsync(cat, isNewItem);
        }
    }
}

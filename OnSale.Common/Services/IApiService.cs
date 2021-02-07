﻿using OnSale.Common.Responses;
using System.Threading.Tasks;
using OnSale.Common.Request;

namespace OnSale.Common.Services
{
    public interface IApiService
    {
        Task<Response> GetListAsync<T>(string urlBase, string servicePrefix, string controller);
        Task<Response> GetTokenAsync(string urlBase, string servicePrefix, string controller, TokenRequest request);

    }
}

using RookieAssignment.CustomerSite.Service.IService;
using RookieAssignment.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RookieAssignment.CustomerSite.Service
{
    public class MenuItemService : Service<MenuItemDTO>, IMenuItemService
    {
        private readonly IHttpClientFactory _clientFactory;

        public MenuItemService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            this._clientFactory = clientFactory;
        }
    }
}

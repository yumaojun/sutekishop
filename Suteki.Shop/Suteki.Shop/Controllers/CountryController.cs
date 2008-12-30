﻿using System.Security.Permissions;

namespace Suteki.Shop.Controllers
{
    [PrincipalPermission(SecurityAction.Demand, Role = "Administrator")]
    public class CountryController : ShopScaffoldController<Country>
    {
    }
}
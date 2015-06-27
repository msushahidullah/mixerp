﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI.WebControls;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Core.Modules.Finance.Data.Helpers;
using MixERP.Net.Entities.Core;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Cache;

namespace MixERP.Net.Core.Modules.Finance.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class CurrencyData : WebService
    {
        [WebMethod]
        public IEnumerable<Currency> GetExchangeCurrencies()
        {
            int officeId = AppUsers.GetCurrentLogin().View.OfficeId.ToInt();
            return Data.Helpers.Currencies.GetExchangeCurrencies(AppUsers.GetCurrentUserDB(), officeId);
        }

        [WebMethod]
        public IEnumerable<CurrencyConversionResult> GetExchangeRates(string moduleName)
        {
            if (string.IsNullOrWhiteSpace(moduleName))
            {
                return null;
            }

            Type type = Type.GetType(moduleName);

            if (type == null)
            {
                return null;
            }

            object instance = Activator.CreateInstance(type);            
            ICurrencyConverter converter = (ICurrencyConverter)instance;

            if (converter == null)
            {
                return null;
            }

            CurrencyData currencyData = new CurrencyData();
            IEnumerable<string> currencies = currencyData.GetExchangeCurrencies().Select(c => c.CurrencyCode);

            converter.BaseCurrency = AppUsers.GetCurrentLogin().View.CurrencyCode;
            converter.CurrencyCodes = currencies.ToList();
            return converter.GetResult();
        }

        [WebMethod]
        public Collection<ListItem> GetModules()
        {
            Collection<ListItem> items = new Collection<ListItem>();

            foreach (CurrencyConverter module in CurrencyConverter.GetEnabled())
            {
                items.Add(new ListItem(module.Name, module.AssemblyQualifiedName));                
            }

            return items;
        }

    }
}
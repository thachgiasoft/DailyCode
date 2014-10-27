﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pineapple.View;
using Pineapple.Core;
using Pineapple.Core.Cache;

namespace Pineapple.Service
{
    public class ManagerNavigationService
    {
        public List<ManagerNavigation> LoadManagerNavigatoin(string activeName)
        {
            var list = new List<ManagerNavigation>();
            list.Add(new ManagerNavigation() { Name = "Overview", Link = "/Manager/Overview", Text = "Overview" });
            list.Add(new ManagerNavigation() { Name = "Catalog", Link = "/Manager/Catalog", Text = "Catalog" });
            list.Add(new ManagerNavigation() { Name = "Category", Link = "/Manager/Category", Text = "Category" });
            list.Add(new ManagerNavigation() { Name = "CategoryItem", Link = "/Manager/CategoryItem", Text = "CategoryItem" });
            list.Add(new ManagerNavigation() { Name = "Navigation", Link = "/Manager/Navigation", Text = "Navigation" });
            list.Add(new ManagerNavigation() { Name = "Template", Link = "/Manager/Template", Text = "Template" });

            list.Find(m => string.Equals(activeName, m.Name, StringComparison.OrdinalIgnoreCase)).Active = "active";

            return list;
        }
    }
}

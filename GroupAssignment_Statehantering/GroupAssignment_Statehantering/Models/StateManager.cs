using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_Statehantering.Models
{
    public class StateManager
    {
        Controller controller;
        IMemoryCache cache;

        public StateManager(IMemoryCache cache, Controller controller)
        {
            this.cache = cache;
            this.controller = controller;
        }

        const string supportEmail = "SupportEmail";
        const string companyName = "CompanyName";
        public const string message = "Message";

        public string SupportEmail
        {   get { return cache.Get<string>(StateManager.supportEmail); }
            set { cache.Set<string>(StateManager.supportEmail, value); }
        }

        public string CompanyName
        {
            get { return controller.HttpContext.Session.GetString(StateManager.companyName); }
            set { controller.HttpContext.Session.SetString(StateManager.companyName, value); }
        }

        public string Message
        {
            get { return (string)controller.TempData[StateManager.message]; }
            set { controller.TempData[StateManager.message] = value; }
        }
    }
}

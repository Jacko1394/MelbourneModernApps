﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace MelbourneModernApp.Core.Services
{
    public class Container
    {
        public static Container Current { get; } = new Container();
        public IServiceProvider Services { get; set; }

        private Container()
        {

        }
    }
}

﻿using Microsoft.Owin;

using RL;

[assembly: OwinStartup(typeof(Startup))]

namespace RL
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
            this.ConfigureNinject(app);
        }
    }
}

﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200395887A1.Startup))]
namespace _200395887A1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

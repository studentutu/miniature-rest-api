using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Weather.Installers
{
    public class DefaultInstallers: IInstaller
    {
        public List<IInstaller> installers = new List<IInstaller>();

        public DefaultInstallers()
        {
            installers.Add(new Db());
            installers.Add(new Mvc());
            installers.Add(new Swagger());
        }

        public void Install(IConfiguration config, IServiceCollection services)
        {
            foreach (IInstaller inst in installers)
            {
               inst.Install(config, services);
            }
        }
    }
}
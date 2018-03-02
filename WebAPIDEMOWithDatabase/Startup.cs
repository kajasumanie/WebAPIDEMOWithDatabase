using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebAPIDEMOWithDatabase.Data;

namespace WebAPIDEMOWithDatabase
{
    public class Startup
    {
        private readonly IConfiguration config;

        public Startup(IConfiguration config)
            {
            this.config = config;
            }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DetailContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app) => app.UseMvc();
    }
}

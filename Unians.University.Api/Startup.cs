﻿using System;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.HealthChecks;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.Models.Interfaces;
using AspNetCore.Infrastructure.Repositories.EntityFrameworkCore.MySql;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Unians.University.Data.Context;
using Unians.University.Data.Models;

namespace Unians.University.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IEfRepository<DbUniversity>, BaseEntityFrameworkCoreRepository<DbUniversity>>();

            services.AddDbContext<UniversityDbContext>();

            services.AddTransient<DbContext, UniversityDbContext>();

            services.AddHealthChecks()
                    .AddCheck<RepositoryHealthCheck<DbUniversity>>("Repository");

            services.AddSwaggerGen(options =>
            {
                var info = new Info
                {
                    Title = "University Web Api",
                    Version = "Vesrion 1",
                    Contact = new Contact
                    {
                        Name = "Danny Etsebban",
                        Email = "dannyets@gmail.com"
                    }
                };

                options.SwaggerDoc("v1", info);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            try
            {
                MySqlDbHelper.MigrateDatabase<UniversityDbContext>(serviceProvider);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to migrate database.");
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHealthChecks("/health");

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "University Web Api");
            });

            app.UseMvc();
        }
    }
}

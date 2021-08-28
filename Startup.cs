using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetAssignment
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                _ = app.UseDeveloperExceptionPage();
            }

            //Hello World From 1st Middleware!Hello World From 2nd Middleware

            //app.Use(async (context, next) =>
            //{
            //   await context.Response.WriteAsync("Hello World From 1st Middleware!");

            //  await next();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World From 2nd Middleware");
            //});



            //Combination 1
            //Hello World From 1st Middleware
            //Hello World From 1st Middleware
            //Hello World!Hello World From 2nd Middleware
            //Hello World From 2nd Middleware


            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello World From 1st Middleware \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello World From 2nd Middleware \n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello World From 1st Middleware\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello World From 2nd Middleware\n");
            //});


            ////Combination 2
            //hello world from 1st middleware
            //hello world from 1st middleware
            //Hello World!hello world from 2nd middleware
            //hello world from 2nd middleware

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello world from 1st middleware\n");
            //    await next();
            //    await context.Response.WriteAsync("hello world from 2nd middleware\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //     await context.Response.WriteAsync("hello world from 1st middleware\n");
            //   await next();
            //   await context.Response.WriteAsync("hello world from 2nd middleware\n");
            //});


            ////Combination 3
            //Hello World From 1st Middleware
            // Hello World From 2nd Middleware
            // Hello World!Hello World From 1st Middleware
            //Hello World From 2nd Middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello World From 1st Middleware \n");
            //    await next();
            //   await context.Response.WriteAsync(" Hello World From 2nd Middleware\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync(" Hello World From 2nd Middleware \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello World From 1st Middleware\n");
            //});


            //Combination 4
            //Hello World From 1st Middleware
            //Hello World From 1st Middleware

            //app.Use(async (context, next) =>
            //  {
            //      await context.Response.WriteAsync("Hello World From 1st Middleware\n");
    
            //      await context.Response.WriteAsync("Hello World From 1st Middleware \n");
            //  });

            //app.Run(async (context) =>
            //{
            //   await context.Response.WriteAsync("Hello World From Terminating middleware\n");
            //});

            ////Combination 5
            //Hello World From 1st Middleware
            //Hello World From 1st Middleware
            //    app.Use(async (context, next) =>
            //    {
            //        await context.Response.WriteAsync(" Hello World From 1st Middleware\n");
            //        await context.Response.WriteAsync("Hello World From 1st Middleware \n");
            //    });

            //    app.Run(async (context) =>
            //    {
            //       await context.Response.WriteAsync("Hello World From Terminating middleware\n");
            //});

            ////Combination 6
            // Hello World From 1st Middleware
            //Hello World From Terminating middleware
            //  Hello World From 1st Middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello World From 1st Middleware\n");
            //    await next();
            //    await context.Response.WriteAsync("Hello World From 1st Middleware \n");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World From Terminating middleware\n");
            //});


            //Combination 7
            //Hello World From 1st Middleware
            //Hello World From 2nd Middleware
            //Hello World!Hello World From 2nd Middleware
            //Hello World From 1st Middleware


            //app.Use(async (context, next) =>
            //{
            //   await context.Response.WriteAsync(" Hello World From 1st Middleware \n");
            //   await next();
            //   await context.Response.WriteAsync("Hello World From 1st Middleware \n");
            //});

            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("Hello World From 2nd Middleware \n");
            //    await next();
            //    await context.Response.WriteAsync("Hello World From 2nd Middleware \n");
            //});



            ////Combination 8
            //Hello World From 1st Middleware
            //Hello World From 2nd Middleware
            //Hello World!Hello World From 2nd Middleware
            //Hello World From 1st Middleware


            app.Use(async (context, next) =>
              {
                  await context.Response.WriteAsync("Hello World From 1st Middleware \n");
                  await next();
                  await context.Response.WriteAsync("Hello World From 1st Middleware \n");
              });

            app.Use(async (context, next) =>
              {
                  await context.Response.WriteAsync("Hello World From 2nd Middleware  \n");
                  await next();
                  await context.Response.WriteAsync("Hello World From 2nd Middleware \n");
              });


            app.UseRouting();

            app.UseEndpoints(endpoints =>
              {
                  _ = endpoints.MapGet("/", async context =>
                  {
                      await context.Response.WriteAsync("Hello World!");
                  });
              });
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace VirtualCnc.Web
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			
			services.AddLogging();
			
			// Register the Swagger generator, defining 1 or more Swagger documents
			services.AddSwaggerGen();
			services.ConfigureSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Info
				{
					Version = "v1",
					Title = "Virtual CNC API",
					Description = "Virtual CNC emulator API",
					TermsOfService = "None",
					Contact = new Contact
					{
						Name = "Vasily Samoylov",
						Email = string.Empty,
						Url = string.Empty,
					},
					License = new License
					{
						Name = "Use under LICX",
						Url = "https://raw.githubusercontent.com/Imagio/VirtualCnc/master/LICENSE"
					}
				});
			});
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();
			
			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();

			// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
				c.RoutePrefix = string.Empty;
			});

			app.UseMvc();
		}
	}
}
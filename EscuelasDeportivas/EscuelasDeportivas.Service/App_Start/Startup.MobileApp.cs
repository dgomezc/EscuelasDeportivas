using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Authentication;
using Microsoft.Azure.Mobile.Server.Config;
using EscuelasDeportivas.Service.DataObjects;
using EscuelasDeportivas.Service.Models;
using Owin;

namespace EscuelasDeportivas.Service
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .ApplyTo(config);

            // Use Entity Framework Code First to create database tables based on your DbContext
            Database.SetInitializer(new MobileServiceInitializer());

            MobileAppSettingsDictionary settings = config.GetMobileAppSettingsProvider().GetMobileAppSettings();

            if (string.IsNullOrEmpty(settings.HostName))
            {
                app.UseAppServiceAuthentication(new AppServiceAuthenticationOptions
                {
                    // This middleware is intended to be used locally for debugging. By default, HostName will
                    // only have a value when running in an App Service application.
                    SigningKey = ConfigurationManager.AppSettings["SigningKey"],
                    ValidAudiences = new[] { ConfigurationManager.AppSettings["ValidAudience"] },
                    ValidIssuers = new[] { ConfigurationManager.AppSettings["ValidIssuer"] },
                    TokenHandler = config.GetAppServiceTokenHandler()
                });
            }

            app.UseWebApi(config);
        }
    }
    
    //public class MobileServiceInitializer : CreateDatabaseIfNotExists<EscuelasDeportivasContext>
    public class MobileServiceInitializer : DropCreateDatabaseIfModelChanges<EscuelasDeportivasContext>
    {
        protected override void Seed(EscuelasDeportivasContext context)
        {
            List<Deporte> deportes = new List<Deporte>
            {
                new Deporte { Id = Guid.NewGuid().ToString(), Nombre = "Fútbol", Descripcion = "Descripción para el deporte Fútbol" },
                new Deporte { Id = Guid.NewGuid().ToString(), Nombre = "Fútbol Sala", Descripcion = "Descripción para el deporte Fútbol Sala" },
                new Deporte { Id = Guid.NewGuid().ToString(), Nombre = "Baloncesto", Descripcion = "Descripción para el deporte Baloncesto" },
                new Deporte { Id = Guid.NewGuid().ToString(), Nombre = "Balonmano", Descripcion = "Descripción para el deporte Balonmano" }
            };

            foreach (Deporte deporte in deportes)
            {
                context.Set<Deporte>().Add(deporte);
            }

            base.Seed(context);
        }
    }
}


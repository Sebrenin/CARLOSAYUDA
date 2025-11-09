using GymRoom_Business.Interfaces;
using GymRoom_Business.Services;
using GymRoom_Data.Interfaces;
using GymRoom_Data.Models;
using GymRoom_Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GymRoom
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContextFactory<GymRoomContext>(opts =>
            {
                opts.UseSqlServer("Server=Anita-San\\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True;TrustServerCertificate=True");
            });

            services.AddTransient<IRepositoryRoutine, RepositoryRoutine>();

            services.AddTransient<IServiceRoutine, ServiceRoutine>();

            services.AddTransient <frmRoutines> ();

            var provider = services.BuildServiceProvider();

            var main = provider.GetRequiredService<frmRoutines>();
            Application.Run(main);
        }
    }
}
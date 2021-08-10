using Consultorio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace Consultorio.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<ConsultorioContext>();
                context.Database.Migrate(); // update-database

                if (!context.Paciente.Any())
                {
                    context.Paciente.Add(new Paciente { Nome = "Pedro", Nascimento = new DateTime(1988, 05, 05), Descricao = "Paciente 1 - Pedro" });
                    context.Paciente.Add(new Paciente { Nome = "Paulo", Nascimento = new DateTime(1988, 05, 05), Descricao = "Paciente 2 - Paulo" });
                    context.Paciente.Add(new Paciente { Nome = "José", Nascimento = new DateTime(1988, 05, 05), Descricao = "Paciente 3 - José" });
                    context.Paciente.Add(new Paciente { Nome = "João", Nascimento = new DateTime(1988, 05, 05), Descricao = "Paciente 4 - João" });
                    context.Paciente.Add(new Paciente { Nome = "Manoel", Nascimento = new DateTime(1988, 05, 05), Descricao = "Paciente 5 - Manoel" });
                }

                context.SaveChanges();
            }
        }
    }
}

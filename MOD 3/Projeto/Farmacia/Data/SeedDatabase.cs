using Farmacia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<RemedioContext>();
                context.Database.Migrate();

                if (!context.Remedio.Any())
                {
                    context.Add(new Remedio { Nome = "Dipirona", Fabricante = "Medley", Quantidade = 43, Preco = 26, Validade = new DateTime(2024, 01, 12) });
                    context.Add(new Remedio { Nome = "Loratadina", Fabricante = "Cimed", Quantidade = 22, Preco = 8, Validade = new DateTime(2022, 02, 21) });
                    context.Add(new Remedio { Nome = "Simeticona", Fabricante = "Needs", Quantidade = 15, Preco = 13, Validade = new DateTime(2021, 03, 06) });
                    context.Add(new Remedio { Nome = "Paracetamol", Fabricante = "Cimed", Quantidade = 50, Preco = 7, Validade = new DateTime(2025, 04, 10) });
                    context.Add(new Remedio { Nome = "Omeprazol", Fabricante = "Medley", Quantidade = 13, Preco = 37, Validade = new DateTime(2021, 05, 04) });
                    context.Add(new Remedio { Nome = "Clonazepam", Fabricante = "Medley", Quantidade = 16, Preco = 21, Validade = new DateTime(2021, 06, 28) });
                    context.Add(new Remedio { Nome = "Ondansetrona", Fabricante = "Ems", Quantidade = 23, Preco = 26, Validade = new DateTime(2022, 07, 15) });
                    context.Add(new Remedio { Nome = "Gliclazida", Fabricante = "Ranbaxy", Quantidade = 19, Preco = 9, Validade = new DateTime(2021, 08, 12) });
                    context.Add(new Remedio { Nome = "Prometazina", Fabricante = "Teuto", Quantidade = 8, Preco = 5, Validade = new DateTime(2020, 09, 03) });
                    context.Add(new Remedio { Nome = "Hidroclorotiazida", Fabricante = "Medley", Quantidade = 6, Preco = 3, Validade = new DateTime(2020, 12, 30) });
                    context.Add(new Remedio { Nome = "Pasurta", Fabricante = "Novartis", Quantidade = 3, Preco = 2500, Validade = new DateTime(2025, 07, 10) });
                    context.Add(new Remedio { Nome = "Canabidiol", Fabricante = "Ems", Quantidade = 5, Preco = 2300, Validade = new DateTime(2026, 09, 05) });
                    context.Add(new Remedio { Nome = "Zyprexa", Fabricante = "Eli Lilly", Quantidade = 5, Preco = 1250, Validade = new DateTime(2024, 05, 03) });
                    context.Add(new Remedio { Nome = "Ozempic", Fabricante = "Novo Nordisk", Quantidade = 6, Preco = 950, Validade = new DateTime(2024, 12, 07) });
                    context.Add(new Remedio { Nome = "Tecta", Fabricante = "Takeda", Quantidade = 10, Preco = 321, Validade = new DateTime(2023, 12, 12) });
                    context.Add(new Remedio { Nome = "Valtrex", Fabricante = "Smart Life", Quantidade = 12, Preco = 630, Validade = new DateTime(2025, 03, 06) });
                    context.Add(new Remedio { Nome = "Pantozol", Fabricante = "Takeda", Quantidade = 2, Preco = 270, Validade = new DateTime(2024, 06, 03) });
                    context.Add(new Remedio { Nome = "Dostinex", Fabricante = "Pfizer", Quantidade = 20, Preco = 280, Validade = new DateTime(2025, 04, 02) });
                    context.Add(new Remedio { Nome = "Quest XR", Fabricante = "Glenmark", Quantidade = 1, Preco = 277, Validade = new DateTime(2024, 11, 08) });
                    context.Add(new Remedio { Nome = "Xarelto", Fabricante = "Bayer", Quantidade = 12, Preco = 299, Validade = new DateTime(2025, 01, 22) });                    
                }
                context.SaveChanges();
            }
        }
    }
}

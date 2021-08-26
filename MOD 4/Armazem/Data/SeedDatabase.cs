using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Armazem.Models;

namespace Armazem.Data
{
    public class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            int qtd_registros = 10;
            string[] nomes = new string[] { "Tábua pinus", "Compensado" };
            string[] medidas = new string[] { "10cm", "20cm", "30cm", "40cm", "50cm", "60cm", "70cm", "80cm", "90cm", "100cm" };

            using(var context = new MAContext(serviceProvider.GetRequiredService<DbContextOptions<MAContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }
                for (int i=0; i < qtd_registros; i++)
                {
                    Random aleartorio = new Random();

                    double preco = aleartorio.Next(1, 1000);
                    var item = $"{nomes[aleartorio.Next(0,nomes.Length)]} {medidas[aleartorio.Next(0, medidas.Length)]}";

                    context.Product.AddRange(
                        new Product
                        {
                            Name = item,
                            Price = preco,
                            Description = "Madeira de reflorestamento."
                        }
                    ); 
                }
                context.SaveChanges();
            }
        }

    }
}

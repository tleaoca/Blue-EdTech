using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Services
{
    public class RemedioStaticService : IRemedioService
    {
        
        public List<Remedio> getRemedios()
        {
            List<Remedio> remedios = new List<Remedio>();
            remedios.Add(new Remedio { Id = 01, Nome = "Dipirona", Fabricante = "Medley", Quantidade = 43, Preco = 26, Validade = new DateTime(2024, 01, 12) });
            remedios.Add(new Remedio { Id = 02, Nome = "Loratadina", Fabricante = "Cimed", Quantidade = 22, Preco = 8, Validade = new DateTime(2022, 02, 21) });
            remedios.Add(new Remedio { Id = 03, Nome = "Simeticona", Fabricante = "Needs", Quantidade = 15, Preco = 13, Validade = new DateTime(2021, 03, 06) });
            remedios.Add(new Remedio { Id = 04, Nome = "Paracetamol", Fabricante = "Cimed", Quantidade = 50, Preco = 7, Validade = new DateTime(2025, 04, 10) });
            remedios.Add(new Remedio { Id = 05, Nome = "Omeprazol", Fabricante = "Medley", Quantidade = 13, Preco = 37, Validade = new DateTime(2021, 05, 04) });
            remedios.Add(new Remedio { Id = 06, Nome = "Clonazepam", Fabricante = "Medley", Quantidade = 16, Preco = 21, Validade = new DateTime(2021, 06, 28) });
            remedios.Add(new Remedio { Id = 07, Nome = "Ondansetrona", Fabricante = "Ems", Quantidade = 23, Preco = 26, Validade = new DateTime(2022, 07, 15) });
            remedios.Add(new Remedio { Id = 08, Nome = "Gliclazida", Fabricante = "Ranbaxy", Quantidade = 19, Preco = 9, Validade = new DateTime(2021, 08, 12) });
            remedios.Add(new Remedio { Id = 09, Nome = "Prometazina", Fabricante = "Teuto", Quantidade = 8, Preco = 5, Validade = new DateTime(2020, 09, 03) });
            remedios.Add(new Remedio { Id = 10, Nome = "Hidroclorotiazida", Fabricante = "Medley", Quantidade = 6, Preco = 3, Validade = new DateTime(2020, 12, 30) });
            return remedios;
        }

        public List<Remedio> all(string id = null, bool ordenar = false)
        {
            if (id != null)
            {
                return getRemedios().FindAll(x =>
                    x.Nome.ToLower().Contains(id.ToLower())
                );
            }
            if (ordenar)
            {
                var lista = getRemedios();
                lista = lista.OrderBy(r => r.Nome).ToList();
                return lista;
            }
            return getRemedios();
        }

        public bool create(Remedio remedio)
        {
            try
            {
                List<Remedio> remedios = getRemedios();
                remedio.Id = remedios.Count() + 1;
                remedios.Add(remedio);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Remedio get(int? id)
        {
            return getRemedios().FirstOrDefault(r => r.Id == id);
        }
        public bool update(Remedio r)
        {
            return false;
        }

        public bool delete(int? id)
        {
            return false;
        }

    }
}

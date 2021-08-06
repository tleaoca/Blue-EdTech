using Farmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Services
{
    public interface IRemedioService
    {
        List<Remedio> all(string id = null, bool ordenar = false);
        public bool create(Remedio remedio);
        public Remedio get(int? id);
        public bool update(Remedio r);
        public bool delete(int? id);
    }
}

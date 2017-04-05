using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data.Entity;

namespace Repository
{
    public class MedioRepository: IMedioRepository
    {
        private SonoVisosContext _context;

        public MedioRepository()
        {
            if (_context == null)
            {
                _context = new SonoVisosContext();
            }
        }
    
public IEnumerable<Medio> GetMedios(string criterio)
{
    var query = from c in _context.Medios select c;

    if (!string.IsNullOrEmpty(criterio))
    {
        query = from c in query
                where c.Titulo.ToUpper().Contains(criterio.ToUpper())
                select c;
    }
    return query;
}

public Medio GetMedio(int id)
{
    return _context.Medios.Find(id);
}

public void AddMedio(Medio medio)
{
    _context.Medios.Add(medio);
    _context.SaveChanges();
}

public void UpdateMedio(Medio medio)
{
    _context.Entry(medio).State = EntityState.Modified;
    _context.SaveChanges();
}

public void DeleteMedio(int medio)
{
    var med = _context.Medios.Find(medio);

    if (med!=null)
    {
         _context.Entry(med).State = EntityState.Deleted;
         _context.SaveChanges();
    }
   
}
}
}

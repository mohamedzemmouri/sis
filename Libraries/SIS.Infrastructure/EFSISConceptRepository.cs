using SIS.Domain.Interfaces;
using SIS.Infrastructure.EFRepository.Context;
using SIS.Infrastructure.EFRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Infrastructure
{
    public class EFSISConceptRepository : ISISConceptRepository
    {
        private readonly SisDbContext _context;

        public EFSISConceptRepository(SisDbContext context)
        {
            _context = context;
        }

        public void Delete(int conceptId)
        {
            var concept= _context.Concepts.FirstOrDefault(c => c.ConceptId == conceptId);
            if (concept != null)
            {
                _context.Concepts.Remove(concept);
                _context.SaveChanges();
            }
        }

        public bool Exists(Concept concept)
        {
            throw new NotImplementedException();
        }

        public void Insert(Concept concept)
        {
            if(concept != null && !_context.Concepts.Contains(concept))
            {
                _context.Concepts.Add(concept);
                _context.SaveChanges();
            }
        }

        public List<Concept> Refreshconcepts()
        {
            return _context.Concepts.ToList();
        }
    }
}

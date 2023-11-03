using SIS.Infrastructure.EFRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Domain.Interfaces
{
    public interface ISISConceptRepository
    {
        public List<Concept> Refreshconcepts();
        public bool Exists(Concept concept);
        public void Insert(Concept concept);
        public void Delete(int conceptId);
    }
}

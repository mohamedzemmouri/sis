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
    public class EFSISInfoTypeRepository : ISISInfoTypeRepository
    {
        private readonly SisDbContext _context;

        public EFSISInfoTypeRepository(SisDbContext context)
        {
            _context = context;
        }

        public void Delete(int conceptId)
        {
            throw new NotImplementedException();
        }

        public bool Exists(InfoType infotype)
        {
            throw new NotImplementedException();
        }

        public void Insert(InfoType infotype)
        {
            EFRepository.Models.InfoType newInfoType = new()
            {
                Name = infotype.Name
            };

            var test = _context.InfoType.Add(newInfoType).Entity;
            var count = _context.SaveChanges();
        }

        public List<InfoType> RefreshInfoType()
        {
            throw new NotImplementedException();
        }
    }
}

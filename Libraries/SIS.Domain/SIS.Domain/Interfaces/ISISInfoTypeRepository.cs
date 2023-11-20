using SIS.Infrastructure.EFRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Domain.Interfaces
{
    public interface ISISInfoTypeRepository
    {
        public List<InfoType> RefreshInfoType();
        public bool Exists(InfoType infotype);
        public void Insert(InfoType infotype);
        public void Delete(int conceptId);
    }
}

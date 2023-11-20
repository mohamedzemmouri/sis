using SIS.Infrastructure.EFRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Domain.Interfaces
{
    public interface ISISInfoRepository
    {
        public Dictionary<string, Info> RefreshInfo();
        public bool Exists(Info info);
        public void Insert(Info info);
        public void Update(Info info);
        public void Delete(Info info);
    }
}

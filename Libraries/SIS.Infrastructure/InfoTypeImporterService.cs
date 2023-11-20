using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SIS.Domain.Interfaces;
using SIS.Infrastructure.EFRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Infrastructure
{
    public class InfoTypeImporterService : IImporter
    {
        private readonly ILogger<InfoTypeImporterService> _logger;
        private readonly IConfiguration _configuration;
        private readonly ISISInfoTypeRepository _Repository;

        public InfoTypeImporterService(ILogger<InfoTypeImporterService> logger, IConfiguration configuration, ISISInfoTypeRepository repository)
        {
            _logger = logger;
            _configuration = configuration;
            _Repository = repository;
        }

        public void Import()
        {
            string json = File.ReadAllText(Path.Combine(_configuration["JsonDataPath"], "InfoType.json"));
            var InfoType = JsonConvert.DeserializeObject<List<InfoType>>(json);
            if (InfoType != null)
            {
                foreach (var i in InfoType)
                {
                    _Repository.Insert(i);
                }
            }
        }
    }
}

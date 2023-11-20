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
    public class InfoImporterService : IImporter
    {
        private readonly ILogger<InfoImporterService> _logger;
        private readonly IConfiguration _configuration;
        private readonly ISISInfoRepository _repository;

        public InfoImporterService(ILogger<InfoImporterService> logger, IConfiguration configuration, ISISInfoRepository repository)
        {
            _logger = logger;
            _configuration = configuration;
            _repository = repository;
        }

        public void Import()
        {
            string json = File.ReadAllText(Path.Combine(_configuration["JsonDataPath"], "Info.json"));
            var Infos = JsonConvert.DeserializeObject<List<Info>>(json);
            if (Infos != null)
            {
                foreach (var i in Infos)
                {
                    _repository.Insert(i);
                }
            }
        }
    }
}

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
    public class ConceptImporterService : IImporter
    {
        private readonly ILogger<ConceptImporterService> _logger;
        private readonly IConfiguration _configuration;
        private readonly ISISConceptRepository _repository;

        public ConceptImporterService(ILogger<ConceptImporterService> logger, IConfiguration configuration, ISISConceptRepository repository)
        {
            _logger = logger;
            _configuration = configuration;
            _repository = repository;
        }

        public void Import()
        {
            string json = File.ReadAllText(Path.Combine(_configuration["JsonDataPath"], "Concept.json"));
            var Concepts = JsonConvert.DeserializeObject<List<Concept>>(json);
            if (Concepts != null)
            {
                foreach (var c in Concepts)
                {
                    _repository.Insert(c);
                }
            }
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SIS.Domain;
using SIS.Domain.Interfaces;

namespace SIS.Infrastructure
{
    public class LectorImporterService : IImporter
    {
        private readonly ILogger<LectorImporterService> _logger;
        private readonly IConfiguration _configuration;
        private readonly ISISTeacherRepository _repository;

        public LectorImporterService(ILogger<LectorImporterService> logger, IConfiguration configuration, ISISTeacherRepository repository)
        {
            _logger = logger;
            _configuration = configuration;
            _repository = repository;
        }

        public void Import()
        {
            string json = File.ReadAllText(Path.Combine(_configuration["JsonDataPath"], "Teachers.json"));
            var teachers = JsonConvert.DeserializeObject<List<Teacher>>(json);
            if (teachers != null)
            {
                foreach (var l in teachers)
                {
                    // TO DO: implement update
                    //// TO DO: implement Upsert for this pattern...
                    //if(_repository.Exists(l))
                    //    _repository.Update(l);
                    //else
                        _repository.Insert(l);
                }
            }
            // RAW SQL Example:
            var teacherNames = _repository.GetNames();
        }
    }
}
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIS.API.DTO;
using SIS.Domain.Interfaces;


namespace SIS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConceptController : ControllerBase
    {
        private readonly ISISConceptRepository _repository;
        private readonly IMapper _mapper;

        public ConceptController(ISISConceptRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetConcepts")]
        public ActionResult<IEnumerable<TeacherDTO>> Get()
        {
            return Ok(_mapper.Map<List<TeacherDTO>>(_repository.Refreshconcepts()));
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIS.API.DTO;
using SIS.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ISISInfoRepository _repository;
        private readonly IMapper _mapper;

        public InfoController(ISISInfoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "getInfo")]
        public ActionResult<IEnumerable<InfoDTO>> Get()
        {
            return Ok(_mapper.Map<List<InfoDTO>>(_repository.RefreshInfo()));
        }
    }
}

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
    public class InfoTypeController : ControllerBase
    {
        private readonly ISISInfoTypeRepository _Repository;
        private readonly IMapper _mapper;

        public InfoTypeController(ISISInfoTypeRepository repository, IMapper mapper)
        {
            _Repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetInfoType")]
        public ActionResult<IEnumerable<InfoTypeDTO>> Get()
        {
            return Ok(_mapper.Map<List<InfoTypeDTO>>(_Repository.RefreshInfoType()));
        }
    }
}

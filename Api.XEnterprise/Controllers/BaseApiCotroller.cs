using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Business.Repositories;
using Api.Data.CommonEntitiesProperty;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.XEnterprise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiCotroller<T, TD> : ControllerBase
      where T : GenericEntity
      where TD : class
    {
        protected readonly GenericRepository<T> _repository;
        protected readonly IMapper _mapper;

        public BaseApiCotroller(IMapper mapper, GenericRepository<T> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}

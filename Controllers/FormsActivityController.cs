using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HubCollege.Data;
using Microsoft.AspNetCore.Mvc;

namespace HubCollege.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormsActivityController : ControllerBase
    {
        // accesing db
        private readonly AppDbContext _appDbContext;

        // constructor
        public FormsActivityController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;    
        }
    }
}
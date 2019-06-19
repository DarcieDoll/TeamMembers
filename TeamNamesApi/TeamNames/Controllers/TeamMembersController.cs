﻿using Microsoft.AspNetCore.Mvc;
using TeamNames.Models;
using TeamNames.Services;

namespace TeamNames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //handles incoming HTTP requests and sends a response back to user

    public class TeamMembersController : ControllerBase
    {
        //POST
        //api/teammembers
        [HttpPost]
        public void Post([FromBody] MemberNameRequest nameRequest)
        {
            var memberService = new MembersService();
            memberService.CreateMember(nameRequest);
        }
    }

}
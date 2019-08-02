﻿using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using TeamNames.Models;
using TeamNames.Services;

namespace TeamNames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //handles incoming HTTP requests and sends a response back to user

    public class TeamMembersController : ControllerBase
    {
        private readonly IMembersService _membersService;

        public TeamMembersController(IMembersService membersService)
        {
            _membersService = membersService;
        }

        //POST
        //api/teammembers
        [HttpPost]
        public void Post([FromBody] TeamMember nameRequest)
        {
            _membersService.CreateMember(nameRequest);
        }

        //GET
        //api/teammembers
        [HttpGet]
        public IEnumerable<TeamMember> Get()
        {
            return _membersService.ViewAllMembers();
        }

        //DELETE
        //api/teammembers/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _membersService.DeleteMember(id);
            return NoContent();

        }

        //PATCH
        //api/teammembers/1
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] JsonPatchDocument<TeamMember> patch)
        {
        
            _membersService.PartialUpdateMember(id, patch);

        }


    }
}
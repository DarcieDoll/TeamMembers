﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using TeamNames.Models;

namespace TeamNames.Services
{
    public interface IMembersService
    {
        void AmendMember(int amendMemberID, string nameUpdate);
        Task<TeamMember> CreateMember(TeamMember nameRequest);
        void DeleteMember(int deleteMemberId);
        void DeleteMembersBulk(int[] deleteBulkMemberIds);
        void PartialUpdateMember(int id, JsonPatchDocument<TeamMember> patch);
        IEnumerable<TeamMember> ViewAllMembers();
        TeamMember[] GetTeamMember(int getMemberId);
        TeamMember[] GetByName(string getMemberName);
    }
}
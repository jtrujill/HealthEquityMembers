using AutoMapper;
using HealthEquityMembers.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthEquityMembers.Controllers
{
    [ApiController]
    [Route("api/[controller]/contact")]
    public class MemberController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMemberRepository _repository;

        public MemberController(IMapper mapper, IMemberRepository memberRepository)
        {
            _mapper = mapper;
            _repository = memberRepository;
        }
        
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var member = _repository.GetMember(id);
            if (member == null)
            {
                return NotFound($"Could not find member by id {id}");
            }
            return Ok(member);
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult PatchMember([FromBody] MemberPatch member, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var memberDto = _mapper.Map<Member>(member);
            memberDto.MemberId = id;

            var updateResult = _repository.UpdateMember(memberDto);
            if (updateResult == null)
            {
                return BadRequest($"Failed to update member {id}");
            }
            return Ok(updateResult);
        }
    }
}
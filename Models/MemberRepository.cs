using System.Linq;

namespace HealthEquityMembers.Models
{
    public class MemberRepository : IMemberRepository
    {
        private readonly MemberContext _context;

        public MemberRepository(MemberContext context)
        {
            _context = context;
        }

        public Member GetMember(long memberId)
        {
            return _context.Members.FirstOrDefault(m => m.MemberId == memberId);
        }

        public Member UpdateMember(Member memberUpdate)
        {
            var member = _context.Members.FirstOrDefault(m => m.MemberId == 1);
            if (member != null)
            {
                member.Email = memberUpdate.Email;
                member.FirstName = memberUpdate.FirstName;
                member.LastName = memberUpdate.LastName;
                member.PhoneNumber = memberUpdate.PhoneNumber;

                // TODO: Need to finish this
                _context.Attach(member);
                _context.Entry(member).Property(p => p.FirstName).IsModified = true;
                _context.SaveChanges();
            }

            return null;
        }
    }
}
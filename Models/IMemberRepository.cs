namespace HealthEquityMembers.Models
{
    public interface IMemberRepository
    {
        Member GetMember(long memberId);
        Member UpdateMember(Member memberUpdate);
    }
}
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member GetMemberById(int memberId) => MemberDAO.Instance.GetMemberById(memberId);
        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList();
        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memberId) => MemberDAO.Instance.Remove(memberId);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);
    }
}

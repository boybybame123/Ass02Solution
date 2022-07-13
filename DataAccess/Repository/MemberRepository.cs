using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMember
    {
        public void DeleteMember(Member p)
        {
            MemberObject.DeleteMember(p);
        }

        public Member GetListMemberbyEmail(string p)=> MemberObject.GetListMemberbyEmail(p);
      

        public List<Member> GetMember() => MemberObject.GetMember();

        public Member LoginMember(string p) => MemberObject.LoginMember(p);
        

        public void SaveMember(Member p)
        {
            MemberObject.SaveMember(p);
        }

        public void UpdateMember(Member p)
        {
            MemberObject.UpdateMember(p);
        }

    }
}

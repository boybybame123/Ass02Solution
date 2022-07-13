using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMember
    {
        void SaveMember(Member p);
        void DeleteMember(Member p);
        void UpdateMember(Member p);
        Member LoginMember(string p);
        Member GetListMemberbyEmail(string p);
        List<Member> GetMember();
    }
}

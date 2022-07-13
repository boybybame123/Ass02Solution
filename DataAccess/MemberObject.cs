using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberObject
    {

        public static List<Member> GetMember()
        {
            var list = new List<Member>();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    list = db.Members.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return list;
        }



        public static void SaveMember(Member p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    db.Members.Add(p);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
       
        public static Member LoginMember(string p)
        {
            var mem = new Member();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    mem = db.Members.SingleOrDefault(c => c.Email == p); 
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mem;
        }
        public static Member GetListMemberbyEmail(string p)
        {
            var mem = new Member();
            try
            {
                using (var db = new FStoreDBContext())
                {
                    mem = db.Members.SingleOrDefault(c => c.Email == p);
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mem;
        }



        public static void UpdateMember(Member p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    db.Entry<Member>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public static void DeleteMember(Member p)
        {

            try
            {
                using (var db = new FStoreDBContext())
                {
                    var b = db.Members.SingleOrDefault(c => c.MemberId == p.MemberId);
                    db.Members.Remove(b);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}

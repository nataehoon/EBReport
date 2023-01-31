using System.Data;

namespace Report_Web.Data
{
    public class MemberService
    {
        public static List<Member> MemberAllSelect() 
        {
            string sql = $"SELECT * FROM MEMBER";
            DataTable dt = SQLServer.SQLServerSelect(sql);
            
            List<Member> members = new List<Member>();
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Member member = new Member();
                member.Id = dt.Rows[i]["Id"].ToString();
                member.Pw = dt.Rows[i]["Pw"].ToString();
                member.Email = dt.Rows[i]["Email"].ToString();

                members.Add(member);
            }

            return members;
        }

        public static Member MemberByIdSelect(string id)
        {
            string sql = $"SELECT * FROM MEMBER WHERE ID = '{id}'";
            DataTable dt = SQLServer.SQLServerSelect(sql);

            Member member = new Member();
            member.Id = dt.Rows[0]["Id"].ToString();
            member.Pw = dt.Rows[0]["Pw"].ToString();
            member.Email = dt.Rows[0]["Email"].ToString();

            return member;
        }
    }
}

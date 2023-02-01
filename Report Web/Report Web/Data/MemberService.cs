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
                member.Position = dt.Rows[i]["Position"].ToString();
                member.Name = dt.Rows[i]["Name"].ToString();

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
            member.Position = dt.Rows[0]["Position"].ToString();
            member.Name = dt.Rows[0]["Name"].ToString();

            return member;
        }

        public static void MemberUpdate(string id, Member model)
        {
            string sql = $"UPDATE MEMBER SET Id='{model.Id}', Pw='{model.Pw}', Email='{model.Email}', Position='{model.Position}', Name='{model.Name}' WHERE Id='{id}'";
            SQLServer.SQLServerUpdate(sql);
        }
    }
}

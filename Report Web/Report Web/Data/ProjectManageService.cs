using Report_Web.Model;
using System.Data;

namespace Report_Web.Data
{
    public class ProjectmanageService
    {
        public static List<ProjectManage> ProjectManageAllSelect()
        {
            string sql = $"SELECT * FROM PROJECTMANAGE";
            DataTable dt = SQLServer.SQLServerSelect(sql);

            List<ProjectManage> projectlist = new List<ProjectManage>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ProjectManage project = new ProjectManage();

                project.Projectno = Convert.ToInt32(dt.Rows[i]["Projectno"]);
                project.Title = dt.Rows[i]["Title"].ToString();
                project.Manager = dt.Rows[i]["Managers"].ToString();
                project.Startperiod = (DateTime)dt.Rows[i]["Startperiod"];
                project.Endperiod = (DateTime)dt.Rows[i]["Endperiod"];

                projectlist.Add(project);
            }

            return projectlist;
        }

        public static void ProjectManageCreate(ProjectManage model)
        {
            string Startperiod = model.Startperiod.ToString("yyyy/MM/dd");
            string Endperiod = model.Endperiod.ToString("yyyy/MM/dd");
            string sql = $"INSERT INTO PROJECTMANAGE(Title, Managers, Startperiod, Endperiod, Totalperiod, Progress) VALUES('{model.Title}','{model.Manager}', '{Startperiod}', '{Endperiod}', 0, 0)";
            SQLServer.SQLServerSelect(sql);
        }

        public static void ProjectManageUpdate(int no, ProjectManage model)
        {
            string Startperiod = model.Startperiod.ToString("yyyy/MM/dd");
            string Endperiod = model.Endperiod.ToString("yyyy/MM/dd");
            string sql = $"UPDATE PROJECTMANAGE SET Title='{model.Title}', Managers='{model.Manager}', Startperiod='{Startperiod}', Endperiod='{Endperiod}', Totalperiod='{model.Totalperiod}', Progress='{model.Progress}' WHERE Projectno = '{no}'";
            SQLServer.SQLServerUpdate(sql);
        }

        public static void ProjectManageDelete(int no)
        {
            Console.WriteLine(no);
            string sql = $"DELETE FROM PROJECTMANAGE WHERE Projectno = '{no}'";
            SQLServer.SQLServerDelete(sql);
        }
    }
}

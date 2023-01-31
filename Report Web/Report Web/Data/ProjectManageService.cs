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

                project.Title = dt.Rows[i]["Title"].ToString();
                project.Manager = dt.Rows[i]["Managers"].ToString();
                project.Startperiod = (DateTime)dt.Rows[i]["Startperiod"];
                project.Endperiod = (DateTime)dt.Rows[i]["Endperiod"];

                projectlist.Add(project);
            }

            return projectlist;
        }

        public static void ProjectmanageCreate(ProjectManage model)
        {
            string sql = $"INSERT INTO PROJECTMANAGE(Title, managers, Startperiod, Endperiod, Totalperiod, Progress) VALUES('{model.Title}','{model.Manager}', '{(DateTime)model.Startperiod}', '{(DateTime)model.Endperiod}', 0, 0)";
            SQLServer.SQLServerSelect(sql);
        }
    }
}

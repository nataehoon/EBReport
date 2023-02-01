using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Report_Web.Data
{
    public class DailyService
    {
        public static List<Daily> DailyByCategorySelect(string category)
        {
            string sql = $"SELECT * FROM DAILY WHERE CATEGORY = '{category}' ORDER BY Dailyno DESC";
            DataTable dt = SQLServer.SQLServerSelect(sql);

            List<Daily> Dailylist = new List<Daily>();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Daily daily = new Daily();

                daily.Category = dt.Rows[i]["Category"].ToString();
                daily.Writer = dt.Rows[i]["Writer"].ToString();
                daily.Title = dt.Rows[i]["Title"].ToString();
                daily.Date = (DateTime)dt.Rows[i]["Regdate"];
                daily.Dailyno = Convert.ToInt32(dt.Rows[i]["Dailyno"]);
                daily.Managers = dt.Rows[i]["Managers"].ToString();
                daily.Important = Convert.ToInt32(dt.Rows[i]["Important"]);
                daily.Progress = dt.Rows[i]["Progress"].ToString();
                daily.Operation = dt.Rows[i]["Operation"].ToString();
                daily.Issue = dt.Rows[i]["Issue"].ToString();

                Dailylist.Add(daily);
            }
            return Dailylist;
        }

        public static void DailyCreate(Daily model)
        {
            string date = model.Date.ToString("yyyy/MM/dd");
            string sql = $"INSERT INTO DAILY(Category, Title, Regdate, Managers, Writer, Important, Progress, Operation, Issue) VALUES('{model.Category}', '{model.Title}', '{date}', '{model.Managers}', '{model.Writer}', '{model.Important}', '{model.Progress}', '{model.Operation}', '{model.Issue}')";
            SQLServer.SQLServerCreateTable(sql);
        }

        public static void DailyUpdate(int no, Daily model)
        {
            string sql = $"UPDATE DAILY SET Title='{model.Title}', Managers='{model.Managers}', Writer='{model.Writer}', Important='{model.Important}', Progress='{model.Progress}', Operation='{model.Operation}', Issue='{model.Issue}' WHERE Dailyno = '{no}'";
            SQLServer.SQLServerUpdate(sql);
        }

        public static void DailyDelete(int no)
        {
            string sql = $"DELETE FROM DAILY WHERE Dailyno = '{no}'";
            SQLServer.SQLServerDelete(sql);
        }
    }
}

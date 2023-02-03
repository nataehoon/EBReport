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

        public static Daily DailyByNoSelect(int no)
        {
            string sql = $"SELECT * FROM DAILY WHERE Dailyno = '{no}'";
            DataTable dt = SQLServer.SQLServerSelect(sql);

            Daily daily = new Daily();

            daily.Category = dt.Rows[0]["Category"].ToString();
            daily.Writer = dt.Rows[0]["Writer"].ToString();
            daily.Title = dt.Rows[0]["Title"].ToString();
            daily.Date = (DateTime)dt.Rows[0]["Regdate"];
            daily.Dailyno = Convert.ToInt32(dt.Rows[0]["Dailyno"]);
            daily.Managers = dt.Rows[0]["Managers"].ToString();
            daily.Important = Convert.ToInt32(dt.Rows[0]["Important"]);
            daily.Progress = dt.Rows[0]["Progress"].ToString();
            daily.Operation = dt.Rows[0]["Operation"].ToString();
            daily.Issue = dt.Rows[0]["Issue"].ToString();

            return daily;
        }
    }
}

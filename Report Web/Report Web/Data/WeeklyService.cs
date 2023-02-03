namespace Report_Web.Data
{
    public class WeeklyService
    {
        public static List<Weekly> WeeklyByCategorySelect(string category) {
            string sql = $"SELECT * FROM WEEKLY WHERE CATEGORY = '{category}'";
            DataTable dt = SQLServer.SQLServerSelect(sql);

            List<Weekly> weeklys = new List<Weekly>();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Weekly weekly = new Weekly();

                weekly.Weeklyno = Convert.ToInt32(dt.Rows[i]["Weeklyno"]);
                weekly.Title = dt.Rows[i]["Title"].ToString();
                weekly.Category = dt.Rows[i]["Category"].ToString();
                weekly.Writer = dt.Rows[i]["Writer"].ToString();
                weekly.Progress = dt.Rows[i]["Progress"].ToString();
                weekly.Operation = dt.Rows[i]["Operation"].ToString();
                weekly.Issue = dt.Rows[i]["Issue"].ToString();

                weeklys.Add(weekly);
            }

            return weeklys;
        }

        public static void WeeklyCreate(Weekly model)
        {
            string date = model.Regdate.ToString("yyyy/MM/dd");
            string sql = $"INSERT INTO WEEKLY(Title, Category, Regdate, Writer, Progress, Operation, Issue) VALUES('{model.Title}', '{model.Category}', '{date}', '{model.Writer}', '{model.Progress}', '{model.Operation}', '{model.Issue}')";
            SQLServer.SQLServerCreateTable(sql);
        }

        public static void WeeklyUpdate(int no, Weekly model)
        {
            string sql = $"UPDATE WEEKLY SEY Title='{model.Title}', Category='{model.Category}', Regdate='{model.Regdate}', Writer='{model.Writer}', Progress='{model.Progress}', Operation='{model.Operation}', Issue='{model.Issue}' WHERE Weeklyno = '{no}'";
            SQLServer.SQLServerUpdate(sql);
        }

        public static void WeeklyDelete(int no)
        {
            string sql = $"DELETE FROM WEEKLY WHERE Weeklyno = '{no}'";
            SQLServer.SQLServerDelete(sql);
        }
    }
}

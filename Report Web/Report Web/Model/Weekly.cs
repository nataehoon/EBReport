namespace Report_Web.Model
{
    public class Weekly
    {
        public int Weeklyno { get; set; }
        public string Title { get; set; } = null!;
        [Editable(false)]
        public string Category { get; set; } = null!;
        public DateTime Regdate { get; set; } = DateTime.Now;
        [Editable(false)]
        public string Writer { get; set; } = null!;
        public string Progress { get; set; }
        public string Operation { get; set; }
        public string Issue { get; set; }
    }
}

namespace Report_Web.Model
{
    public class ProjectManage
    {
        [Editable(false)]
        public int Projectno { get; set; }
        [Display(Name = "프로젝트 명")]
        public string? Title { get; set; }
        [Display(Name = "프로젝트 참여 인원")]
        public string? Manager { get; set; }
        [Display(Name = "프로젝트 시작일")]
        public DateTime Startperiod { get; set; }
        [Display(Name = "프로젝트 종료일")]
        public DateTime Endperiod { get; set; }
        [Editable(false)]
        public int Progress { get; set; }
        [Editable(false)]
        public int Totalperiod { get; set; }
    }
}

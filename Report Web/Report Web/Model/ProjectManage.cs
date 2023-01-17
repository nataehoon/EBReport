namespace Report_Web.Model
{
    public class ProjectManage
    {
        [Editable(false)]
        public int no { get; set; }
        [Display(Name = "프로젝트 명")]
        public string? title { get; set; }
        [Display(Name = "프로젝트 참여 인원")]
        public string? member { get; set; }
        [Display(Name = "프로젝트 시작일")]
        public DateTime startperiod { get; set; }
        [Display(Name = "프로젝트 종료일")]
        public DateTime endperiod { get; set; }
        [Editable(false)]
        public int progress { get; set; }
        [Editable(false)]
        public int totalperiod { get; set; }
    }
}

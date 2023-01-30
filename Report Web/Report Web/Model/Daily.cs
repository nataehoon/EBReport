namespace Report_Web.Model
{
    public class Daily
    {
        public int No { get; set; }
        [Editable(false)]
        public string? Category { get; set; }
        [Display(Name = "제목")]
        public string? Title { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [Editable(false)]
        public string? Managers { get; set; }
        [Display(Name = "작성자")]
        public string? Writer { get; set; }
        [Display(Name = "중요도")]
        public string? Important { get; set; }
        [Display(Name = "진행 사항")]
        public string? Progress { get; set; }
        [Display(Name = "운영 사항")]
        public string? Operation { get; set; }
        [Display(Name = "이슈 사항")]
        public string? Issue { get; set; }
    }
}

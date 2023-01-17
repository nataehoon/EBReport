namespace Report_Web.Model
{
    public class Daily
    {
        public int no { get; set; }
        [Editable(false)]
        public string? category { get; set; }
        [Display(Name = "제목")]
        public string? title { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
        [Editable(false)]
        public string? managers { get; set; }
        [Display(Name = "작성자")]
        public string? writer { get; set; }
        [Display(Name = "중요도")]
        public string? important { get; set; }
        [Display(Name = "진행 사항")]
        public string? progress { get; set; }
        [Display(Name = "운영 사항")]
        public string? operation { get; set; }
        [Display(Name = "이슈 사항")]
        public string? issue { get; set; }
    }
}

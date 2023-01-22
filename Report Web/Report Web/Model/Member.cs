namespace Report_Web.Model
{
    public class Member
    {
        [Display(Name = "아이디")]
        public string? Id { get; set; }
        [Display(Name = "비밀번호")]
        public string? Pw { get; set; }
        [Display(Name = "이메일")]
        public string? Email { get; set; }
    }
}

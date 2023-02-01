namespace Report_Web.Model
{
    public class Member
    {
        [Display(Name = "아이디")]
        public string Id { get; set; } = null!;
        [Display(Name = "비밀번호")]
        public string Pw { get; set; } = null!;
        [Display(Name = "이메일")]
        public string Email { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}

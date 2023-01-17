namespace Report_Web.Model
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string subt { get; set; }
        public string Icon { get; set; }
        public string ImageClass { get; set; }
        public string ImageUrl { get; set; }
        public List<MenuItem> Items { get; set; }
    }
}

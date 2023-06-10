namespace Task_PurpleBuzz.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ImgPath { get; set; }
        public int WorkCategoryId { get; set; }
        public WorkCategory WorkCategory { get; set; }
    }
}

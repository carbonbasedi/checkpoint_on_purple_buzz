namespace Task_PurpleBuzz.Models
{
	public class WorkCategory
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}

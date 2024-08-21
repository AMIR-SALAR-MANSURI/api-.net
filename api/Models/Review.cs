namespace api.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string tEXT { get; set; }

        public Revier Reviewer { get; set; }

        
       public Pokemon Pokemon  { get; set; }
    }

}

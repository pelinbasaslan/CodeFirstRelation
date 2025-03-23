namespace CodeFirstRelation.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //Relational properties
        public int UserId { get; set; }
    }
}
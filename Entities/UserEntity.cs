namespace CodeFirstRelation.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        //Relational properties
        public List<PostEntity> Posts { get; set; }
    }
}
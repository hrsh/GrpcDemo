namespace GrpcDemo.Server
{
    public class BookEntity
    {
        public BookEntity(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; set; }

        public string Title { get; set; }
    }
}

namespace Phonestore.Domain.Entity.Phone
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime DateCreate { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public byte[]? Avatar { get; set; }
    }
}

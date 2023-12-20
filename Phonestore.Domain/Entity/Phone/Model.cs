namespace Phonestore.Domain.Entity.Phone
{
    // Класс телефона - модель
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OperationSystem { get; set; }
        public string Processor { get; set; }
        public string Battery { get; set; }
        public string Camera { get; set; }
        public string Display { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public int PhoneId { get; set; }
        public Phone Phone { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
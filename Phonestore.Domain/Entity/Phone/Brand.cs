﻿namespace Phonestore.Domain.Entity.Phone
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Model Model { get; set; }
    }
}
﻿namespace Data.Entities.VenichleInfo
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Venichle>? Venichles { get; set; }
        public ICollection<Model>? Models { get; set; }  

    }
}

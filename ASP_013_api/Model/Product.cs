﻿namespace ASP_013_api.Model
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public int price { get; set; }
        public int categoryId { get; set; }
    }
}

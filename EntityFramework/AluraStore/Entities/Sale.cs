using System;
using System.Collections.Generic;

namespace AluraStore.Entities
{
    public class Sale
    {
        public int Id { get; internal set; }
        public string Description { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime FinishDate { get; internal set; }
        public List<Product> Products { get; internal set; }
    }
}

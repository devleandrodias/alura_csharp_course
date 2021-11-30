namespace AluraStore.Entities
{
    public class Address
    {
        public string Stree { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public Customer Customer { get; set; }
    }
}

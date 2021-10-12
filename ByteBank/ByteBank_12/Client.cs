namespace ByteBank_12
{
    public class Client
    {
        public string Name { get; set; }

        public string Cpf { get; set; }

        public string Job { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is not Client client) return false;

            return Cpf == client.Cpf;
        }
    }
}

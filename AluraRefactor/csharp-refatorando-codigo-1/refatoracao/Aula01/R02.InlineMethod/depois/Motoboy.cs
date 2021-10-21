namespace refatoracao.R02.InlineMethod.depois
{
    class Motoboy
    {
        private readonly int _qtdeEntregasNoturnas;

        public int GetAvaliacao()
        {
            return (_qtdeEntregasNoturnas > 5) ? 2 : 1;
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace AluraStore
{
    internal class ProductDAO : IDisposable, IProductDAOADO
    {
        private readonly SqlConnection _connection;

        internal class ProductADO
        {
            public int Id { get; internal set; }
            public string Name { get; internal set; }
            public string Category { get; internal set; }
            public double Price { get; internal set; }

            public override string ToString()
            {
                return $"Product {Id}, {Name} - {Category}, {Price}";
            }
        }

        public ProductDAO()
        {
            _connection = new SqlConnection("Password=uzumymwsql9432!;Persist Security Info=True;User ID=sa;Initial Catalog=AluraStore;Data Source=localhost,1433");
            _connection.Open();
        }

        public void Dispose()
        {
            _connection.Close();
        }

        public void Add(ProductADO p)
        {
            try
            {
                var insertCmd = _connection.CreateCommand();
                insertCmd.CommandText = "INSERT INTO Products (Name, Category, Price) VALUES (@name, @category, @price)";

                var paramName = new SqlParameter("name", p.Name);
                insertCmd.Parameters.Add(paramName);

                var paramCategory= new SqlParameter("category", p.Category);
                insertCmd.Parameters.Add(paramCategory);

                var paramPrice = new SqlParameter("price", p.Price);
                insertCmd.Parameters.Add(paramPrice);

                insertCmd.ExecuteNonQuery();
            }

            catch (SqlException e)
            {
                throw new SystemException(e.Message, e);
            }
        }

        public void Update(ProductADO p)
        {
            try
            {
                var updateCmd = _connection.CreateCommand();
                updateCmd.CommandText = "UPDATE Products SET Name = @name, Category = @category, Price = @price WHERE Id = @id";

                var paramId = new SqlParameter("id", p.Id);
                var paramNome = new SqlParameter("name", p.Name);
                var paramCategoria = new SqlParameter("category", p.Category);
                var paramPreco = new SqlParameter("price", p.Price);

                updateCmd.Parameters.Add(paramNome);
                updateCmd.Parameters.Add(paramCategoria);
                updateCmd.Parameters.Add(paramPreco);
                updateCmd.Parameters.Add(paramId);

                updateCmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw new SystemException(e.Message, e);
            }
        }

        public void Remove(ProductADO p)
        {
            try
            {
                var deleteCmd = _connection.CreateCommand();
                deleteCmd.CommandText = "DELETE FROM Products WHERE Id = @id";

                var paramId = new SqlParameter("id", p.Id);
                deleteCmd.Parameters.Add(paramId);

                deleteCmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw new SystemException(e.Message, e);
            }
        }

        public IList<ProductADO> Products()
        {
            var lista = new List<ProductADO>();

            var selectCmd = _connection.CreateCommand();

            selectCmd.CommandText = "SELECT * FROM Products";

            var resultado = selectCmd.ExecuteReader();

            while (resultado.Read())
            {
                ProductADO p = new();

                p.Id = Convert.ToInt32(resultado["Id"]);
                p.Name = Convert.ToString(resultado["Name"]);
                p.Category = Convert.ToString(resultado["Category"]);
                p.Price = Convert.ToDouble(resultado["Price"]);
                
                lista.Add(p);
            }

            resultado.Close();

            return lista;
        }
    }
}
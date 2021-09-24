using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace AluraStore
{
    internal class ProductDAO : IDisposable
    {
        private readonly SqlConnection _connection;

        public ProductDAO()
        {
            _connection = new SqlConnection("Password=uzumymwsql9432!;Persist Security Info=True;User ID=sa;Initial Catalog=AluraStore;Data Source=localhost,1433");
            _connection.Open();
        }

        public void Dispose()
        {
            _connection.Close();
        }

        internal void Add(Product p)
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

        internal void Update(Product p)
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

        internal void Remove(Product p)
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

        internal IList<Product> Products()
        {
            var lista = new List<Product>();

            var selectCmd = _connection.CreateCommand();

            selectCmd.CommandText = "SELECT * FROM Products";

            var resultado = selectCmd.ExecuteReader();

            while (resultado.Read())
            {
                Product p = new();

                p.Id = Convert.ToInt32(resultado["Id"]);
                p.Name = Convert.ToString(resultado["Nome"]);
                p.Category = Convert.ToString(resultado["Categoria"]);
                p.Price = Convert.ToDouble(resultado["Preco"]);
                
                lista.Add(p);
            }

            resultado.Close();

            return lista;
        }
    }
}
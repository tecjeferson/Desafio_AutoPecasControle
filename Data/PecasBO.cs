using lojaDePecasDeCarro.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace lojaDePecasDeCarro.Data
{
    public class PecasBO
    {
        private string GetConnectionString()
        {
            return (WebConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString);
        }

        public List<Pecas> GetPecas()
        {
            List<Pecas> pecas = new List<Pecas>();
            try
            {
                string connectionString = GetConnectionString();
                string commandSql = @"SELECT * FROM PecasAuto";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(commandSql, sqlConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Pecas _pecas = new Pecas();

                        _pecas.Id = Convert.ToInt32(reader["Id"]);
                        _pecas.Name = reader["Name"].ToString();
                        _pecas.Description = reader["Description"].ToString();
                        _pecas.Price = Convert.ToInt32(reader["Price"]);
                        _pecas.InStock = Convert.ToBoolean(reader["InStock"]);
                        pecas.Add(_pecas);

                    }
                }
                sqlConnection.Close();
                return (pecas);
               
            }
            catch (Exception err)
            {
                throw err;
            }

            
            
        }
    }
}
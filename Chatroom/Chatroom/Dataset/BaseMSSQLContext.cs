using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Chatroom.Dataset
{
    public class BaseMssqlContext
    {
        private string _connect;
        public BaseMssqlContext()
        {
            var configuration = GetConfiguration();
            this._connect = configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }

        public IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional:true, reloadOnChange:true);
            return builder.Build();
        }

        public DataTable ExecuteQuery(string query, List<KeyValuePair<object, object>> parameters)
        {
            DataTable set = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(_connect);
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = connection.CreateCommand();

                foreach (KeyValuePair<object, object> keyvaluepair in parameters)
                {
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@" + keyvaluepair.Key;
                    parameter.Value = keyvaluepair.Value;
                    command.Parameters.Add(parameter);
                }

                command.CommandText = query;
                adapter.SelectCommand = command;

                connection.Open();
                adapter.Fill(set);
                connection.Close();
                return set;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
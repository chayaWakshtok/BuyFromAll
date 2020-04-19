using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Tools.MySqlCustomClientFactory
{
    public class CustomFactory : DbProviderFactory
    {
        public static CustomFactory Instance = new CustomFactory();
        public override DbCommand CreateCommand()
        {
            return MySqlClientFactory.Instance.CreateCommand();
        }

        public override DbConnection CreateConnection()
        {
            return MySqlClientFactory.Instance.CreateConnection();
        }

        public override DbParameter CreateParameter()
        {
            return MySqlClientFactory.Instance.CreateParameter();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new MySqlDataAdapter();
        }

        private CustomFactory()
        {

        }
    }
}

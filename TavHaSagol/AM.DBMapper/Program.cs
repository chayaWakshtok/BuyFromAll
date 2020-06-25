using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.DBMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var options = new CmdOptions();
                CommandLine.Parser.Default.ParseArguments(args, options);
                IDbMapper mapper = null;
                switch (options.DataProvider)
                {
                    case "System.Data.SqlClient":
                        mapper = new DBMapperMSSql(options.ConStr);
                        break;
                    case "MySql.Data.MySqlClient":
                        mapper = new DbMapperMySql(options.ConStr);
                        break;
                    default:
                        break;
                }
                string[] ignoreTables = null;
                if (!String.IsNullOrEmpty(options.IgnoreTables))
                    ignoreTables = options.IgnoreTables.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                string targetFile = Path.Combine(options.TargetFolder, "DbContent.cs");

                string[] ignoreUpdateColumns = null;
                if (!String.IsNullOrEmpty(options.IgnoreUpdateColumns))
                    ignoreUpdateColumns = options.IgnoreUpdateColumns.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                mapper.MapDataBase(targetFile, options.Namespace, ignoreTables, ignoreUpdateColumns);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

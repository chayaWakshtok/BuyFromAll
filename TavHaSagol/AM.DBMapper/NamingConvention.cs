using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.DBMapper
{
    public static class NamingConvention
    {
        public static string SetNamingConvention(string columnName)
        {
            int index = 0;
            //var columnProperty = new StringBuilder(columnName.ToLower());
            while (index > -1)
            {
                index = columnName.ToString().IndexOf("_");
                if (index != -1)
                {
                    columnName = columnName.Remove(index, 1);//remove the "_"
                    string charToInsert = Char.ToUpper(columnName[index]).ToString();
                    columnName = columnName.Remove(index, 1);
                    columnName = columnName.Insert(index, charToInsert);//make the '_' followed char to upper
                }
            }
            return Char.ToUpper(columnName.ToString()[0]) + columnName.ToString().Substring(1);
        }
    }
}

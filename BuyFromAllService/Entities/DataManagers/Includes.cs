using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataManagers
{
    public class Includes
    {
        string[] _includes;

        public bool Contains(string include)
        {
            if (_includes == null) return false;
            return _includes.FirstOrDefault((s) => { return s == include; }) != null;
        }

        public Includes(params string[] includes)
        {
            _includes = includes;
        }
    }
}

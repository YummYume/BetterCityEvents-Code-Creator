using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4EventGenerator
{
    public static class Utilities
    {
        public static string ToCapName(string name)
        {
            if (name == null)
            {
                return null;
            }

            if (name.Length > 1)
            {
                return char.ToUpper(name[0]) + name.Substring(1);
            }

            return name.ToUpper();
        }
    }
}

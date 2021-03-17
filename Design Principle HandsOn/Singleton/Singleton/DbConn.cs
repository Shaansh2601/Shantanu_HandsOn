using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class DbConn
    {
        private static DbConn instance=new DbConn();
        public DbConn() {
        }

        public static DbConn getInstance
        {
            get
            {
                return instance;
            }
        }

    }
}

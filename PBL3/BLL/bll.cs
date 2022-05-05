using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class bll
    {
        private static bll _Instance;
        public static bll Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new bll();
                }
                return _Instance;
            }
            private set { }
        }
    }
}

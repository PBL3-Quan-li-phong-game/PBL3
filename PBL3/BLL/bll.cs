using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;
using PBL3.Model.obj;
using PBL3.OnViewOBJ;

namespace PBL3.BLL
{
    public class bll
    {
        private Model_Net NetModel = new Model_Net();
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

        public List<userOnView> getViewUsers()
        {
            List<userOnView> data = new List<userOnView>();
            foreach(USERS i in NetModel.USERs.Where(p => p.ROLE.Name != "AD"))
            {
                data.Add(new userOnView(i));
            }
            return data;
        }
    }
}

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
        private Model_Net NetModel;
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
            NetModel = new Model_Net();
            List<userOnView> data = new List<userOnView>();
            foreach(USERS i in NetModel.USERs.Where(p => p.ROLE.Name != "AD"))
            {
                data.Add(new userOnView(i));
            }
            NetModel.Dispose();
            return data;
        }
        public List<pcOnView> getViewPC()
        {
            NetModel = new Model_Net();
            List<pcOnView> data = new List<pcOnView>();
            foreach(PC i in NetModel.PCs)
            {
                data.Add(new pcOnView(i));
            }
            NetModel.Dispose();
            return data;
        }
        public USERS GetUser(string username, string pwd) 
        {
            NetModel = new Model_Net();
            USERS user = NetModel.USERs.Find(username);
            NetModel.Dispose();
            if (user == null) { return null; }
            else
            {
                if(user.PWD != pwd) { return null; }
                else
                {
                    return user;
                }
            }
        }
        public bool CheckOnlineADMOD()
        {
            NetModel = new Model_Net();
            List<USERS> li = NetModel.USERs.Where(p => p.RoleID < 3).Where(p => p.OnlineStatus == true).ToList();
            NetModel.Dispose();
            if (li.Count > 0) return true;
            return false;
        }
        public void onLogin(USERS user)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.OnlineStatus = true;
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public void onLogout(USERS user)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.OnlineStatus = false;
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
    }
}

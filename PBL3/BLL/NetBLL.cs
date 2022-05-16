using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model;
using PBL3.Model.Context;
using PBL3.OnViewContext;

namespace PBL3.BLL
{
    public class NetBLL
    {
        private Model_Net NetModel;
        private static NetBLL _Instance;
        public static NetBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NetBLL();
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
        public USERS getUserbyUserName(string UserName)
        {
            NetModel = new Model_Net();
            USERS user = NetModel.USERs.Find(UserName);
            return user;
        }
        public List<PC> GetAllPC()
        {
            List<PC> data = new List<PC>();
            NetModel = new Model_Net();
            foreach(PC i in NetModel.PCs)
            {
                data.Add(i);
            }
            return data;
        }
        public PC getPCbyID(string ID)
        {
            NetModel = new Model_Net();
            PC p = NetModel.PCs.Find(ID);
            return p;
        }
        public bool CheckOnlineADMOD()
        {
            NetModel = new Model_Net();
            List<USERS> li = NetModel.USERs.Where(p => p.RoleID < 3).Where(p => p.OnlineStatus == true).ToList();
            if (li.Count > 0) return true;
            return false;
        }
        public void onLogin(USERS user, PC pc = null)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.OnlineStatus = true;
            u.LastLogin = DateTime.Now;
            if(pc != null)
            {
                PC p = NetModel.PCs.Find(pc.ID);
                u.UsingPC = p.ID;
                p.USERS.Add(u);
                p.StatusID = 2;
            }
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public void onLogout(USERS user, PC pc = null)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.OnlineStatus = false;
            if(pc != null)
            {
                PC p = NetModel.PCs.Find(pc.ID);
                u.UsingPC = null;
                p.USERS.Remove(u);
                p.StatusID = 1;
            }
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public void addUser(USERS user)
        {
            NetModel = new Model_Net();
            NetModel.USERs.Add(user);
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public void MoneyCharge(USERS user, int Amount)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.RemainingMoney += Amount;
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
    }
}

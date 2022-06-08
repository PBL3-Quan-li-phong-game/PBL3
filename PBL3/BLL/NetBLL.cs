using PBL3.DTO;
using PBL3.Model;
using PBL3.Model.Context;
using PBL3.OnViewContext;
using System;
using System.Collections.Generic;
using System.Linq;

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

        ///*********************GENERAL METHOD*************************///
        public USERS GetUser(string username, string pwd)
        {
            NetModel = new Model_Net();
            USERS user = NetModel.USERs.Find(username);
            NetModel.Dispose();
            if (user == null) return null;
            if (user.UserName != username) return null;
            else
            {
                if (user.PWD != pwd) { return null; }
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
        public void UpdateUser(USERS user)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.RemainingMoney = user.RemainingMoney;
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public List<LOGIN_HISTORY> getLoginHistory(USERS user)
        {
            List<LOGIN_HISTORY> data = new List<LOGIN_HISTORY>();
            NetModel = new Model_Net();
            data = NetModel.LOGIN_HISTORY.Where(p => p.UserName == user.UserName).OrderByDescending(p => p.ID).ToList();
            return data;
        }
        public List<PC> GetAllPC()
        {
            List<PC> data = new List<PC>();
            NetModel = new Model_Net();
            foreach (PC i in NetModel.PCs)
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
        public USERS getOnlineADMOD()
        {
            NetModel = new Model_Net();
            List<USERS> li = NetModel.USERs.Where(p => p.RoleID < 3).Where(p => p.OnlineStatus == true).ToList();
            USERS user = li.ElementAt(0);
            return user;
        }
        public void onLogin(USERS user, PC pc = null)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.OnlineStatus = true;
            u.LastLogin = DateTime.Now;
            if (pc != null)      //vai trò player
            {
                PC p = NetModel.PCs.Find(pc.ID);
                u.UsingPC = p.ID;
                p.USERS.Add(u);
                p.StatusID = 2;
                NetModel.RECEIPTs.Add(new RECEIPT
                {
                    UserName = user.UserName,
                    TotalPrice = 0,
                    FormedDate = u.LastLogin
                });
            }
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public void onLogout(USERS user, PC pc = null, int ReceiptID = 0)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.OnlineStatus = false;
            LOGIN_HISTORY lh = new LOGIN_HISTORY
            {
                UserName = u.UserName,
                PCID = null,
                LoginTime = u.LastLogin,
                LogoutTime = DateTime.Now
            };
            if (pc != null) //vai trò player
            {
                PC p = NetModel.PCs.Find(pc.ID);
                lh.PCID = p.ID;
                u.UsingPC = null;
                p.USERS.Remove(u);
                p.StatusID = 1;
                RECEIPT r = NetModel.RECEIPTs.Find(ReceiptID);
                foreach (RECEIPT_ITEM ri in NetModel.RECEIPT_ITEMs.Where(item => item.ReceiptID == ReceiptID).ToList())
                {
                    r.TotalPrice += ri.Amount * NetModel.SERVICEs.Find(ri.ServiceID).UnitPrice;
                }
                if (r.TotalPrice == 0) NetModel.RECEIPTs.Remove(r);
            }
            NetModel.LOGIN_HISTORY.Add(lh);
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public List<RECEIPT_ITEM> getAllReceiptItembyReceiptID(int ReceiptID)
        {
            NetModel = new Model_Net();
            List<RECEIPT_ITEM> data = new List<RECEIPT_ITEM>();
            data = NetModel.RECEIPT_ITEMs.Where(p => p.ReceiptID == ReceiptID).ToList();
            return data;
        }
        public void addChatLog(CHAT_LOG log)
        {
            NetModel = new Model_Net();
            NetModel.CHAT_LOGs.Add(log);
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public RECEIPT getReceiptbyID(int ID)
        {
            NetModel = new Model_Net();
            RECEIPT r = NetModel.RECEIPTs.Find(ID);
            return r;
        }

        ///*******************END GENERAL METHOD************************///


        ///*******************ADMIN_MOD SECTION*************************///

        public List<userOnView> getViewUsers()
        {
            NetModel = new Model_Net();
            List<userOnView> data = new List<userOnView>();
            foreach (USERS i in NetModel.USERs.Where(p => p.ROLE.Name != "AD"))
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
            foreach (PC i in NetModel.PCs)
            {
                data.Add(new pcOnView(i));
            }
            NetModel.Dispose();
            return data;
        }
        public List<userOnView> getViewUserbySearch(string search)
        {
            List<userOnView> data = new List<userOnView>();
            foreach (userOnView u in NetBLL.Instance.getViewUsers())
            {
                if (u.UserName.ToUpper().Contains(search.ToUpper())) data.Add(u);
            }
            return data;
        }
        public List<pcOnView> getViewPCbySearch(string search)
        {
            List<pcOnView> data = new List<pcOnView>();
            foreach (pcOnView pc in NetBLL.Instance.getViewPC())
            {
                if (pc.ID.ToUpper().Contains(search.ToUpper())) data.Add(pc);
            }
            return data;
        }
        public List<receiptOnView> getViewReceiptofUser(string UserName)
        {
            List<receiptOnView> data = new List<receiptOnView>();
            List<RECEIPT> r = NetBLL.Instance.getListReceiptbyUserName(UserName);
            foreach (RECEIPT receipt in r)
            {
                data.Add(new receiptOnView(receipt));
            }
            return data;
        }
        public List<ReceipItemOnView> getViewReceiptItemofUser(string UserName)
        {
            List<ReceipItemOnView> data = new List<ReceipItemOnView>();
            if (UserName == null) return data;
            RECEIPT r = NetBLL.Instance.getLastReceiptRecordof(UserName);
            if (r == null) return data;
            NetModel = new Model_Net();
            foreach(RECEIPT_ITEM i in NetModel.RECEIPT_ITEMs.Where(p => p.ReceiptID == r.ID).ToList())
            {
                data.Add(new ReceipItemOnView(i));
            }
            NetModel.Dispose();
            return data;
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
        public void ChangePWD(USERS user, string NewPWD)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            u.PWD = NewPWD;
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public void ResetPWD(USERS user)
        {
            ChangePWD(user, "1");
        }
        public void DelUser(USERS user)
        {
            NetModel = new Model_Net();
            USERS u = NetModel.USERs.Find(user.UserName);
            NetModel.USERs.Remove(u);
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public void AddReceiptItem(RECEIPT_ITEM ri)
        {
            NetModel = new Model_Net();
            NetModel.RECEIPT_ITEMs.Add(ri);
            NetModel.SaveChanges();
            NetModel.Dispose();
        }
        public List<StatiticItem> Statitic(int Range)
        {
            NetModel = new Model_Net();
            List<StatiticItem> data = new List<StatiticItem>();
            foreach (SERV s in NetModel.SERVICEs.ToList())
            {
                data.Add(new StatiticItem { ID = s.ID, ServiceName = s.Name, Unit = s.Unit, TotalCount = 0 });
            }

            List<RECEIPT> rList = new List<RECEIPT>();
            switch (Range)
            {
                case 0: //trong ngày
                    foreach (RECEIPT r in NetModel.RECEIPTs.ToList())
                    {
                        if ((DateTime.Now.Date - r.FormedDate.Date).TotalDays <= 1) rList.Add(r);
                    }
                    break;
                case 1: //trong tuần
                    foreach (RECEIPT r in NetModel.RECEIPTs.ToList())
                    {
                        if ((DateTime.Now.Date - r.FormedDate.Date).TotalDays <= 7) rList.Add(r);
                    }
                    break;
                case 2: //trong tháng
                    foreach (RECEIPT r in NetModel.RECEIPTs.ToList())
                    {
                        if ((DateTime.Now.Date - r.FormedDate.Date).TotalDays <= 30) rList.Add(r);
                    }
                    break;
                default: //all
                    rList = NetModel.RECEIPTs.ToList();
                    break;
            }

            List<RECEIPT_ITEM> riList = new List<RECEIPT_ITEM>();
            foreach (RECEIPT r in rList)
            {
                riList.AddRange(NetModel.RECEIPT_ITEMs.Where(p => p.ReceiptID == r.ID).ToList());
            }

            foreach (StatiticItem s in data)
            {
                foreach (RECEIPT_ITEM ri in riList)
                {
                    if (ri.ServiceID == s.ID)
                    {
                        s.TotalCount += ri.Amount;
                    }
                }
            }

            return data;
        }


        ///*******************END ADMIN_MOD SECTION*************************///


        ///**********************PLAYER SECTION*****************************///

        public List<SERV> getAllService()
        {
            NetModel = new Model_Net();
            List<SERV> data = new List<SERV>();
            foreach (SERV s in NetModel.SERVICEs)
            {
                data.Add(s);
            }
            NetModel.Dispose();
            return data;
        }
        public SERV getServicebyID(string ID)
        {
            NetModel = new Model_Net();
            SERV s = NetModel.SERVICEs.Find(ID);
            return s;
        }
        public List<RECEIPT> getListReceiptbyUserName(string UserName)
        {
            NetModel = new Model_Net();
            List<RECEIPT> data = new List<RECEIPT>();
            data = NetModel.RECEIPTs.Where(p => p.UserName == UserName).OrderByDescending(p => p.ID).ToList();
            NetModel.Dispose();
            return data;
        }
        public RECEIPT getLastReceiptRecordof(string UserName)
        {
            return NetBLL.Instance.getListReceiptbyUserName(UserName).ElementAt(0);
        }

        ///********************END PLAYER SECTION***************************///
    }
}

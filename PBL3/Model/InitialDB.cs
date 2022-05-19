using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model.Context;


namespace PBL3.Model
{
    public class InitialDB : CreateDatabaseIfNotExists<Model_Net>
    {
        protected override void Seed(Model_Net context)
        {
            context.AREAs.AddRange(new AREA[]
            {
                new AREA { ID = 1, Name = "NORM", Cost = 4000.0},
                new AREA { ID = 2, Name = "HIGH", Cost = 5000.0},
                new AREA { ID = 3, Name = "VIP", Cost = 7000.0}
            });

            context.PC_STATUSes.AddRange(new PC_STATUS[]
            {
                new PC_STATUS { ID = 1, StatusName = "OFF"},
                new PC_STATUS { ID = 2, StatusName = "ON"},
                new PC_STATUS { ID = 3, StatusName = "NA"}
            });

            context.PCs.AddRange(new PC[]
            {
                new PC { ID = "N0001", AreaID = 1, StatusID = 1},
                new PC { ID = "N0002", AreaID = 1, StatusID = 1},
                new PC { ID = "N0003", AreaID = 1, StatusID = 1},
                new PC { ID = "H0001", AreaID = 2, StatusID = 1},
                new PC { ID = "H0002", AreaID = 2, StatusID = 1},
                new PC { ID = "H0003", AreaID = 2, StatusID = 1},
                new PC { ID = "VI0001", AreaID = 3, StatusID = 1},
                new PC { ID = "VI0002", AreaID = 3, StatusID = 1},
                new PC { ID = "VI0003", AreaID = 3, StatusID = 1},
                new PC { ID = "VI0004", AreaID = 3, StatusID = 1},
            });

            context.ROLEs.AddRange(new ROLES[]
            {
                new ROLES { ID = 1, Name = "AD" },
                new ROLES { ID = 2, Name = "MOD"},
                new ROLES { ID = 3, Name = "Player"}
            });

            context.USERs.AddRange(new USERS[]
            {
                new USERS { UserName = "ADMIN", PWD = "123456789aA", RoleID = 1, RegisterDate = DateTime.Now, LastLogin = DateTime.Now, OnlineStatus = false},
                new USERS { UserName = "MOD1", PWD = "123456789", RoleID = 2, RegisterDate = DateTime.Now, LastLogin = DateTime.Now, OnlineStatus = false},
                new USERS { UserName = "user01", PWD = "123123123", RoleID = 3, RegisterDate = DateTime.Now, LastLogin = DateTime.Now, OnlineStatus = false},
                new USERS { UserName = "user02", PWD = "123", RoleID = 3, RegisterDate = DateTime.Now, LastLogin = DateTime.Now, OnlineStatus = false},
                new USERS { UserName = "user03", PWD = "123456789", RoleID = 3, RegisterDate = DateTime.Now, LastLogin = DateTime.Now, OnlineStatus = false}
            });

            context.SERVICEs.AddRange(new SERV[]
            {
                new SERV { ID = "MiTom", Name = "Mì Tôm", Unit = "Tô", UnitPrice = 10000.0},
                new SERV { ID = "MiTomTrung", Name = "Mì Tôm Trứng", Unit = "Tô", UnitPrice = 15000.0},
                new SERV { ID = "RedSting", Name = "String Đỏ", Unit = "Chai", UnitPrice = 10000.0},
                new SERV { ID = "ylSting", Name = "String Vàng", Unit = "Chai", UnitPrice = 10000.0},
                new SERV { ID = "Coca", Name = "CocaCola", Unit = "Chai", UnitPrice = 10000.0},
                new SERV { ID = "7up", Name = "7up", Unit = "Chai", UnitPrice = 10000.0},
                new SERV { ID = "Pepsi", Name = "Pepsi", Unit = "Chai", UnitPrice = 10000.0},
                new SERV { ID = "Aqua", Name = "Aquafina 500ml", Unit = "Chai", UnitPrice = 10000.0},
                new SERV { ID = "Sprite", Name = "Sprite", Unit = "Lon", UnitPrice = 10000.0},
                new SERV { ID = "Mirinda", Name = "Mirinda", Unit = "Lon", UnitPrice = 10000.0},
            });
        }
    }
}

using PBL3.Model.Context;
using System.Data.Entity;


namespace PBL3.Model
{
    public class Model_Net : DbContext
    {
        public Model_Net()
            : base("name=Model_Net")
        {
            Database.SetInitializer<Model_Net>(new InitialDB());
        }
        public virtual DbSet<AREA> AREAs { get; set; }
        public virtual DbSet<PC_STATUS> PC_STATUSes { get; set; }
        public virtual DbSet<PC> PCs { get; set; }
        public virtual DbSet<ROLES> ROLEs { get; set; }
        public virtual DbSet<USERS> USERs { get; set; }
        public virtual DbSet<LOGIN_HISTORY> LOGIN_HISTORY { get; set; }
        public virtual DbSet<CHAT_LOG> CHAT_LOGs { get; set; }
        public virtual DbSet<SERV> SERVICEs { get; set; }
        public virtual DbSet<RECEIPT> RECEIPTs { get; set; }
        public virtual DbSet<RECEIPT_ITEM> RECEIPT_ITEMs { get; set; }

    }
}
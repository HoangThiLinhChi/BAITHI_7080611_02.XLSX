namespace HoangThiLinhChi_08.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_TinhThanhs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TinhThanhs",
                c => new
                    {
                        MaTinhThanh = c.Int(nullable: false, identity: true),
                        TenTinhThanh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaTinhThanh);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TinhThanhs");
        }
    }
}

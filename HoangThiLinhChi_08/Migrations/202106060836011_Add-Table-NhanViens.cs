namespace HoangThiLinhChi_08.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableNhanViens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        MaTinhThanh = c.String(),
                        TinhThanh_MaTinhThanh = c.Int(),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.TinhThanhs", t => t.TinhThanh_MaTinhThanh)
                .Index(t => t.TinhThanh_MaTinhThanh);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "TinhThanh_MaTinhThanh", "dbo.TinhThanhs");
            DropIndex("dbo.NhanViens", new[] { "TinhThanh_MaTinhThanh" });
            DropTable("dbo.NhanViens");
        }
    }
}

namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categoridetyasil : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kategoris", "KategoriDetay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
        }
    }
}

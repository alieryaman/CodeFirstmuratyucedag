namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categoriaadcolondegisirme2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "Kategorisim", c => c.String());
            DropColumn("dbo.Kategoris", "KategorAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategorAdi", c => c.String());
            DropColumn("dbo.Kategoris", "Kategorisim");
        }
    }
}

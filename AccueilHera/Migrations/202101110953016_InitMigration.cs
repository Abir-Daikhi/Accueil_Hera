namespace AccueilHera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abonnements",
                c => new
                    {
                        Id_Abonnement = c.Int(nullable: false, identity: true),
                        Nom_Abonnement = c.String(),
                        Description_Abonnement = c.String(),
                        Prix_Abonnement = c.String(),
                        Statut_Abonnement = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Abonnement);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abonnements");
        }
    }
}

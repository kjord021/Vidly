namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes Set Name = 'Pay as You Go' WHERE ID = 1");
            Sql("UPDATE MembershipTypes Set Name = 'Monthly' WHERE ID = 2");
            Sql("UPDATE MembershipTypes Set Name = 'Quarterly' WHERE ID = 3");
            Sql("UPDATE MembershipTypes Set Name = 'Annual' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}

namespace MVCLectures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypesWithNames : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET Name = 'Guest' WHERE Id = 1");
            Sql("Update MembershipTypes SET Name = 'Silver Member' WHERE Id = 2");
            Sql("Update MembershipTypes SET Name = 'Gold Member' WHERE Id = 3");
            Sql("Update MembershipTypes SET Name = 'Platinum Member' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}

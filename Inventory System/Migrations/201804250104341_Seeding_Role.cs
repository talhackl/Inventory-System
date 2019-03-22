namespace Inventory_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seeding_Role : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'5324b428-cca9-40cd-a715-f703f91d077d', N'talhackl', N'AJwSHGQezCPOz+nYMZfsfguJ7MwoXiKthKFudjNv6Fw36b8x6M1f4CQuXD2ZekW4VA==', N'8e939c82-38d4-4130-9c2f-efa488542ddc', N'ApplicationUser')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'fa632c8e-a2aa-4842-8533-1a09affc39ec', N'elviShCkl', N'AHxZU4OSLFyjfYPPmqAEMaGVoKN8ggStBpz1BCa+a75gkz/bjypf9yXXS9UfSOdZVQ==', N'65694d27-99a6-478a-8028-c224820cfc20', N'ApplicationUser')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2d1de101-c715-4292-a12c-722eb20ae7bd', N'canManageData')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fa632c8e-a2aa-4842-8533-1a09affc39ec', N'2d1de101-c715-4292-a12c-722eb20ae7bd')

                
             ");
        }
        
        public override void Down()
        {
        }
    }
}

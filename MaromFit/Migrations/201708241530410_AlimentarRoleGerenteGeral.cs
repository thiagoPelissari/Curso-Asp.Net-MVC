namespace MaromFit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlimentarRoleGerenteGeral : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4379118d-45aa-4d97-898d-344644b8f27c', N'admin@hotmail.com', 0, N'ALvfov9o9e8TcyUhnEwwTXjj6Z2lLMCIu7m4pWfUL8eWiz15VkIqp3UetQ821LBfFA==', N'6be57645-0048-46c6-a05b-7c4e9e914dc3', NULL, 0, 0, NULL, 1, 0, N'admin@hotmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8cae363c-7e08-4a62-9f92-13c973b94663', N'teste@teste.com', 0, N'ALvfov9o9e8TcyUhnEwwTXjj6Z2lLMCIu7m4pWfUL8eWiz15VkIqp3UetQ821LBfFA==', N'd8cddc60-f80e-433a-b33a-60f21dd3776f', NULL, 0, 0, NULL, 1, 0, N'teste@teste.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'92dc5380-7a84-4f4d-becf-c739ee2e1b64', N'GerenteGeral')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4379118d-45aa-4d97-898d-344644b8f27c', N'92dc5380-7a84-4f4d-becf-c739ee2e1b64')

            ");
        }
        
        public override void Down()
        {

        }
    }
}

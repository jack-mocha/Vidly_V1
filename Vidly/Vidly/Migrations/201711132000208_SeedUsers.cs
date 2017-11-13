namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bc9f5687-0a8c-4255-b2b6-2fd9590932af', N'guest@vidly.com', 0, N'AAqyMGZadF/o/nnwfxOjCv1Y30yOF73QHez/0iDVKkOfG4Hw3hK2b94ESQy8zPDidw==', N'77ed6eb8-61ad-40d0-ac91-92c650a67627', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bf9a6091-cbc9-4f7b-9078-590f6341e5d7', N'admin@vidly.com', 0, N'ADBrmssAJF6SYmnvpqwpI9yh3Q6PiYeiqk94T5WUD+M3ZNdLuB9ojOY1MTRnvfnm8g==', N'8ba02e49-63fe-4c9b-92cf-758af6209ebe', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'283f9177-112f-46ee-a961-330d2513cc81', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bf9a6091-cbc9-4f7b-9078-590f6341e5d7', N'283f9177-112f-46ee-a961-330d2513cc81')
");
        }
        
        public override void Down()
        {
        }
    }
}

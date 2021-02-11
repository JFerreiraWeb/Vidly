namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'815512bd-ce56-4fb5-9faf-922ad5eb646c', N'guest@vidly.com', 0, N'AL6LD3++qQivPHWUdN4HnL8yU+RsfMyXjLoTSS60GKVwjQP6P+F2qGk+wvrXnCvjqg==', N'a63d53a3-82ad-4f07-b505-779f1fd61587', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd6949432-6e6a-4123-9cc8-d2b282b03646', N'admin@vidly.com', 0, N'AONhRsHGuOggyWVNlQY5t5Xqk23KynJJwg2ZWvc7CMkkpVqDjTMYHgi3qctMr7FJPw==', N'899886a7-f09e-4830-aea3-83af6ebbb297', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1247c686-2e00-463f-a9d1-219443d0ce6f', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd6949432-6e6a-4123-9cc8-d2b282b03646', N'1247c686-2e00-463f-a9d1-219443d0ce6f')
            ");
        }
        
        public override void Down()
        {
        }
    }
}

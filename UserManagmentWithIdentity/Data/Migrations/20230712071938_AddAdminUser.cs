using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagmentWithIdentity.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture])" +
                                                        " VALUES (N'004141d6-2cd5-4fe5-976b-0b1c1f96a190', N'admin', N'ADMIN', N'admin@test.com', N'ADMIN@TEST.COM', 0, N'AQAAAAEAACcQAAAAEEzOcbpa9QcjbShZ0cSpB9JS+V6HHKDiSafufYy6FGBYCPAY2ZnJ5cgSVh7l7vmE1Q==', N'F4ZHBQI3VASYHWSMI4QMUDU54TH2BDIU', N'e43fe25a-53a9-43ea-9149-f61a104ceb31', NULL, 0, 0, NULL, 1, 0, N'Admin', N'Admin', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = '004141d6-2cd5-4fe5-976b-0b1c1f96a190'");

        }
    }
}

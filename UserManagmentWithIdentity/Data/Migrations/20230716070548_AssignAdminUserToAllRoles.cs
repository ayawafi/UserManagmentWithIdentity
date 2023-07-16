using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagmentWithIdentity.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles](UserId, RoleId) SELECT '004141d6-2cd5-4fe5-976b-0b1c1f96a190', Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId = '004141d6-2cd5-4fe5-976b-0b1c1f96a190'");
        }
    }
}

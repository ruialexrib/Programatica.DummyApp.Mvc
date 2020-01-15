using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Programatica.DummyApp.Mvc.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SystemId = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUser = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    LastModifiedUser = table.Column<string>(nullable: true),
                    LastDestroyedDate = table.Column<DateTime>(nullable: true),
                    LastDestroyedUser = table.Column<string>(nullable: true),
                    IsSystem = table.Column<bool>(nullable: false),
                    IsDestroyed = table.Column<bool>(nullable: false),
                    ContentSystemId = table.Column<Guid>(nullable: false),
                    ContentId = table.Column<int>(nullable: false),
                    ContentType = table.Column<string>(nullable: true),
                    ContentFunction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SystemId = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUser = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    LastModifiedUser = table.Column<string>(nullable: true),
                    LastDestroyedDate = table.Column<DateTime>(nullable: true),
                    LastDestroyedUser = table.Column<string>(nullable: true),
                    IsSystem = table.Column<bool>(nullable: false),
                    IsDestroyed = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Teste = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrackChanges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SystemId = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedUser = table.Column<string>(nullable: true),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    LastModifiedUser = table.Column<string>(nullable: true),
                    LastDestroyedDate = table.Column<DateTime>(nullable: true),
                    LastDestroyedUser = table.Column<string>(nullable: true),
                    IsSystem = table.Column<bool>(nullable: false),
                    IsDestroyed = table.Column<bool>(nullable: false),
                    AuditId = table.Column<int>(nullable: false),
                    FieldName = table.Column<string>(nullable: true),
                    OldValue = table.Column<string>(nullable: true),
                    NewValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrackChanges_Audit_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Comments", "CreatedDate", "CreatedUser", "Email", "IsDestroyed", "IsSystem", "LastDestroyedDate", "LastDestroyedUser", "LastModifiedDate", "LastModifiedUser", "Name", "Password", "SystemId", "Teste" },
                values: new object[] { 1, null, null, null, "user1@mail.com", false, false, null, null, null, null, "User1", "123", new Guid("8ca76361-ad8b-487e-afb5-ba63970969e5"), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Comments", "CreatedDate", "CreatedUser", "Email", "IsDestroyed", "IsSystem", "LastDestroyedDate", "LastDestroyedUser", "LastModifiedDate", "LastModifiedUser", "Name", "Password", "SystemId", "Teste" },
                values: new object[] { 2, null, null, null, "user2@mail.com", false, false, null, null, null, null, "User2", "123", new Guid("222c370d-be16-47cd-9271-e4c53451592f"), null });

            migrationBuilder.CreateIndex(
                name: "IX_TrackChanges_AuditId",
                table: "TrackChanges",
                column: "AuditId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackChanges");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Audit");
        }
    }
}

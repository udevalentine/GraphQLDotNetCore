using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLDotNetCore.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GENDER",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GENDER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PERSON",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSON", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STATE",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    GeoPoliticalZoneId = table.Column<int>(nullable: false),
                    GeoPoliticalZoneId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STATE_USER_GeoPoliticalZoneId1",
                        column: x => x.GeoPoliticalZoneId1,
                        principalTable: "USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LGA",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LGA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LGA_STATE_StateId",
                        column: x => x.StateId,
                        principalTable: "STATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "GENDER",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[,]
                {
                    { 1L, true, "Male" },
                    { 2L, true, "Female" }
                });

            migrationBuilder.InsertData(
                table: "PERSON",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[,]
                {
                    { 1L, true, "Admin" },
                    { 2L, true, "SuperAdmin" },
                    { 3L, true, "Student" },
                    { 4L, true, "Agent" }
                });

            migrationBuilder.InsertData(
                table: "STATE",
                columns: new[] { "Id", "Active", "GeoPoliticalZoneId", "GeoPoliticalZoneId1", "Name" },
                values: new object[,]
                {
                    { 18L, true, 3, null, "Jigawa" },
                    { 19L, true, 3, null, "Kaduna" },
                    { 20L, true, 3, null, "Kano" },
                    { 21L, true, 3, null, "Katsina" },
                    { 22L, true, 3, null, "Kebbi" },
                    { 23L, true, 1, null, "Kogi" },
                    { 24L, true, 1, null, "Kwara" },
                    { 25L, true, 6, null, "Lagos" },
                    { 26L, true, 1, null, "Nassarawa" },
                    { 29L, true, 6, null, "Ondo" },
                    { 28L, true, 6, null, "Ogun" },
                    { 17L, true, 5, null, "Imo" },
                    { 30L, true, 6, null, "Osun" },
                    { 31L, true, 6, null, "Oyo" },
                    { 32L, true, 1, null, "Plateau" },
                    { 33L, true, 5, null, "Rivers" },
                    { 34L, true, 3, null, "Sokoto" },
                    { 35L, true, 2, null, "Taraba" },
                    { 27L, true, 1, null, "Niger" },
                    { 16L, true, 2, null, "Gombe" },
                    { 13L, true, 6, null, "Ekiti" },
                    { 14L, true, 4, null, "Enugu" },
                    { 1L, true, 4, null, "Abia" },
                    { 2L, true, 2, null, "Adamawa" },
                    { 3L, true, 5, null, "Akwa-Ibom" },
                    { 15L, true, 1, null, "FCT Abuja" },
                    { 5L, true, 2, null, "Bauchi" },
                    { 6L, true, 5, null, "Bayelsa" },
                    { 4L, true, 4, null, "Anambra" },
                    { 8L, true, 2, null, "Borno" },
                    { 9L, true, 5, null, "Cross-Rivers" },
                    { 10L, true, 5, null, "Delta" },
                    { 11L, true, 4, null, "Ebonyi" },
                    { 12L, true, 5, null, "Edo" },
                    { 36L, true, 2, null, "Yobe" },
                    { 7L, true, 1, null, "Benue" },
                    { 37L, true, 3, null, "Zamfara" }
                });

            migrationBuilder.InsertData(
                table: "USER",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[,]
                {
                    { 6L, true, "South West" },
                    { 5L, true, "South South" },
                    { 4L, true, "South East" },
                    { 3L, true, "North West" },
                    { 2L, true, "North East" },
                    { 1L, true, "North Central" }
                });

            migrationBuilder.InsertData(
                table: "LGA",
                columns: new[] { "Id", "Active", "Name", "StateId" },
                values: new object[,]
                {
                    { 1L, true, "Udi", 14L },
                    { 2L, true, "Oji-River", 14L },
                    { 3L, true, "Nsukka", 14L },
                    { 4L, true, "Ogwu", 14L },
                    { 5L, true, "Enugu", 14L },
                    { 6L, true, "Eziagu", 14L },
                    { 7L, true, "Ilaro", 28L },
                    { 8L, true, "Obiakpo", 33L },
                    { 9L, true, "Port-Harcourt", 33L },
                    { 10L, true, "Degema", 33L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LGA_StateId",
                table: "LGA",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_STATE_GeoPoliticalZoneId1",
                table: "STATE",
                column: "GeoPoliticalZoneId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GENDER");

            migrationBuilder.DropTable(
                name: "LGA");

            migrationBuilder.DropTable(
                name: "PERSON");

            migrationBuilder.DropTable(
                name: "STATE");

            migrationBuilder.DropTable(
                name: "USER");
        }
    }
}

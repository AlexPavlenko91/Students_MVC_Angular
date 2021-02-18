using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class Assets_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("896df545-7acd-4f23-9d3c-604e91189420"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("ad8a9943-8fde-4b9e-b37f-feb029d2001e"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("bc7a0439-addd-4cef-bded-33e55b974cb1"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("cfe9617b-69e1-4fc9-bb85-74d55a3f6a0d"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("3a0d5bfe-4298-43d9-b0ac-928747c39b9b"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("63a287fa-7c02-4abc-9c05-4d79536a5afb"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("dc375d5a-0655-477d-8f85-44470a184a4a"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("e553f08b-fafb-4c92-8fa3-5ff0a4687a9d"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bac3b569-7637-4d4a-a6ec-4af47190854d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "bd2cee95-90d0-4332-8243-bef53dbf5b96");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("3c25cabf-edff-4473-8733-98fb635090ec"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("8d84c9d1-c882-4fd2-923c-7fbebf9bca19"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("97c5f034-5f5c-427b-8de1-f7cd9a160300"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("e2aa47b5-ab54-42a3-8d42-4d27df158600"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("fa5d7fed-8c4c-4082-ba1a-a7da163d7917"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("01ee1f02-6dea-4a41-9497-aa202cceec58"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("6d91dc2b-9a65-46d8-abbe-e9877ea28d83"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("8a20755c-9215-499b-8242-0535111168bf"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("bade60cc-8761-4f18-9845-0e85aed233a7"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("d16fc464-4d0d-469f-a2c7-df595804476f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("1cbf6e95-e6f0-4ab7-a5b0-f313c8fa2ed4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("2ab93055-8f5b-40af-a8df-dd1211af4801"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("97fc8c45-a9e6-4335-b297-22d3d3bac5d9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("dfe04a23-61ec-4267-9bc3-c391d6f4e8af"));

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    fileExtention = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    originalFileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    mimeType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("2b0167c3-4274-4085-b507-61ef3e88ae91"), "5-A" },
                    { new Guid("6473af05-90c6-4fd9-bf06-664fad796b98"), "29-B" },
                    { new Guid("5de8818f-c87a-443f-a713-0fb4306fe3d0"), "10" },
                    { new Guid("14ce5e54-ae1b-43bc-b5c2-34f7a72191ad"), "22-C" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("d67be1f3-788d-4a3d-b83f-301c15c6ab5f"), "Информационных технологий" },
                    { new Guid("07619f02-7ae2-4319-8540-78685939b38a"), "Радиоэлектроники" },
                    { new Guid("8de4b2e6-725a-4701-ae3f-69021d21777c"), "Электротехники" },
                    { new Guid("20ccc995-8bb0-4c7d-91ce-489d12e8d1c6"), "Ядерной физики" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("1aa9ba32-64e3-498a-a1d9-bca29cd66afe"), "Базовый" },
                    { new Guid("d3ccd887-83ae-4bbe-89db-99e7adea371a"), "Дизайна и графики" },
                    { new Guid("71b88ce2-14bd-4cbb-8e74-981414055c5a"), "Администрирования" },
                    { new Guid("8d0ef1a9-da9e-4aa4-aa47-5d93647094a9"), "Программирования" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "239e87e7-50c6-4c33-9d5c-fa8293dcba46", "c4f0273a-957b-43a2-bf07-caae019345f3", "Administrators", "ADMINISTRATORS" },
                    { "c1235b93-988d-44f4-ada3-44abe88b4c6b", "7e967a11-70c8-4e75-9e1a-96e29716a994", "Moderators", "MODERATORS" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("6840ca8f-8b65-4de2-81b3-e5b01901f552"), "ASP.NET" },
                    { new Guid("426835bd-e8ca-4be5-9c09-0743be7b4081"), "React Redux" },
                    { new Guid("6baaa249-ff55-4305-9df5-2cb5080bf029"), "Angular" },
                    { new Guid("58e31f6f-7794-4cfa-a082-e6971337f0cb"), "MSSQL" },
                    { new Guid("f5dc7b6e-75de-413f-87b8-b3e82d3c91d0"), "Windows Forms" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "id", "departmentId", "firstName", "lastName" },
                values: new object[,]
                {
                    { new Guid("79452f57-680d-42b5-8b39-1465d3514d1b"), new Guid("d67be1f3-788d-4a3d-b83f-301c15c6ab5f"), "Василий", "Петренко" },
                    { new Guid("4d1d6c79-65b7-4ad4-8dbf-a5f7da4831eb"), new Guid("d67be1f3-788d-4a3d-b83f-301c15c6ab5f"), "Андрей", "Пилипенко" },
                    { new Guid("71969563-a08d-480d-ba8d-c834918547f7"), new Guid("07619f02-7ae2-4319-8540-78685939b38a"), "Алексей", "Затворницкий" },
                    { new Guid("a0971cc8-fc5d-47cd-b507-9063fa214a2a"), new Guid("8de4b2e6-725a-4701-ae3f-69021d21777c"), "Геннадий", "Узелков" },
                    { new Guid("87517b59-7250-4fac-b56d-b0f5cc1b6978"), new Guid("20ccc995-8bb0-4c7d-91ce-489d12e8d1c6"), "Александр", "Усик" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("14ce5e54-ae1b-43bc-b5c2-34f7a72191ad"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("2b0167c3-4274-4085-b507-61ef3e88ae91"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("5de8818f-c87a-443f-a713-0fb4306fe3d0"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("6473af05-90c6-4fd9-bf06-664fad796b98"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("1aa9ba32-64e3-498a-a1d9-bca29cd66afe"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("71b88ce2-14bd-4cbb-8e74-981414055c5a"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("8d0ef1a9-da9e-4aa4-aa47-5d93647094a9"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("d3ccd887-83ae-4bbe-89db-99e7adea371a"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "239e87e7-50c6-4c33-9d5c-fa8293dcba46");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c1235b93-988d-44f4-ada3-44abe88b4c6b");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("426835bd-e8ca-4be5-9c09-0743be7b4081"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("58e31f6f-7794-4cfa-a082-e6971337f0cb"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("6840ca8f-8b65-4de2-81b3-e5b01901f552"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("6baaa249-ff55-4305-9df5-2cb5080bf029"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "id",
                keyValue: new Guid("f5dc7b6e-75de-413f-87b8-b3e82d3c91d0"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("4d1d6c79-65b7-4ad4-8dbf-a5f7da4831eb"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("71969563-a08d-480d-ba8d-c834918547f7"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("79452f57-680d-42b5-8b39-1465d3514d1b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("87517b59-7250-4fac-b56d-b0f5cc1b6978"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("a0971cc8-fc5d-47cd-b507-9063fa214a2a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("07619f02-7ae2-4319-8540-78685939b38a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("20ccc995-8bb0-4c7d-91ce-489d12e8d1c6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("8de4b2e6-725a-4701-ae3f-69021d21777c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("d67be1f3-788d-4a3d-b83f-301c15c6ab5f"));

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("bc7a0439-addd-4cef-bded-33e55b974cb1"), "5-A" },
                    { new Guid("896df545-7acd-4f23-9d3c-604e91189420"), "29-B" },
                    { new Guid("cfe9617b-69e1-4fc9-bb85-74d55a3f6a0d"), "10" },
                    { new Guid("ad8a9943-8fde-4b9e-b37f-feb029d2001e"), "22-C" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("1cbf6e95-e6f0-4ab7-a5b0-f313c8fa2ed4"), "Информационных технологий" },
                    { new Guid("2ab93055-8f5b-40af-a8df-dd1211af4801"), "Радиоэлектроники" },
                    { new Guid("97fc8c45-a9e6-4335-b297-22d3d3bac5d9"), "Электротехники" },
                    { new Guid("dfe04a23-61ec-4267-9bc3-c391d6f4e8af"), "Ядерной физики" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("3a0d5bfe-4298-43d9-b0ac-928747c39b9b"), "Базовый" },
                    { new Guid("e553f08b-fafb-4c92-8fa3-5ff0a4687a9d"), "Дизайна и графики" },
                    { new Guid("63a287fa-7c02-4abc-9c05-4d79536a5afb"), "Администрирования" },
                    { new Guid("dc375d5a-0655-477d-8f85-44470a184a4a"), "Программирования" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd2cee95-90d0-4332-8243-bef53dbf5b96", "bf235aa6-341c-471e-b3c7-4c9be349e20c", "Administrators", "ADMINISTRATORS" },
                    { "bac3b569-7637-4d4a-a6ec-4af47190854d", "10899756-aad7-4271-8f16-ee28b375c788", "Moderators", "MODERATORS" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("3c25cabf-edff-4473-8733-98fb635090ec"), "ASP.NET" },
                    { new Guid("8d84c9d1-c882-4fd2-923c-7fbebf9bca19"), "React Redux" },
                    { new Guid("97c5f034-5f5c-427b-8de1-f7cd9a160300"), "Angular" },
                    { new Guid("e2aa47b5-ab54-42a3-8d42-4d27df158600"), "MSSQL" },
                    { new Guid("fa5d7fed-8c4c-4082-ba1a-a7da163d7917"), "Windows Forms" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "id", "departmentId", "firstName", "lastName" },
                values: new object[,]
                {
                    { new Guid("01ee1f02-6dea-4a41-9497-aa202cceec58"), new Guid("1cbf6e95-e6f0-4ab7-a5b0-f313c8fa2ed4"), "Василий", "Петренко" },
                    { new Guid("bade60cc-8761-4f18-9845-0e85aed233a7"), new Guid("1cbf6e95-e6f0-4ab7-a5b0-f313c8fa2ed4"), "Андрей", "Пилипенко" },
                    { new Guid("8a20755c-9215-499b-8242-0535111168bf"), new Guid("2ab93055-8f5b-40af-a8df-dd1211af4801"), "Алексей", "Затворницкий" },
                    { new Guid("d16fc464-4d0d-469f-a2c7-df595804476f"), new Guid("97fc8c45-a9e6-4335-b297-22d3d3bac5d9"), "Геннадий", "Узелков" },
                    { new Guid("6d91dc2b-9a65-46d8-abbe-e9877ea28d83"), new Guid("dfe04a23-61ec-4267-9bc3-c391d6f4e8af"), "Александр", "Усик" }
                });
        }
    }
}

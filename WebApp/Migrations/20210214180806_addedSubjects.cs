using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class addedSubjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("24798d7f-bda3-4fcb-9a95-c1effa3bf07e"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("b317409b-4663-43f5-ab8e-bbf6c6ca36f7"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("c2b531cd-08c1-4f86-b922-efdddbace473"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("d3485256-2e7f-41b9-b7f8-0efb0bdf056c"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("3d149501-5e31-46de-bae2-b20d4d09ea19"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("63189e90-5c7e-40dc-bf5f-c04b58731d42"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("8182e4fc-cd26-42c5-ba97-b7de0c3af9ff"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("ba9cf275-a11f-4459-af20-7d04072112e8"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8c5fec19-0be4-4e93-b427-79e111a48d3f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ebb940d4-b91b-4a06-b17b-c90bf0b8ea34");

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("0b90c34f-bfce-49f5-9e9b-bbb78d1161f9"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("4dc242eb-2875-43ee-883b-7faf9a8a4127"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("75839303-cf6e-4be0-a200-ab84469b1ed1"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("89feda8e-e81f-4ee2-81c8-ddc788a07f73"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "id",
                keyValue: new Guid("8eec3c13-3619-41a0-911e-b90e442d5152"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("303b1933-8f58-42c4-8535-51820e4a2571"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("39d05296-9691-42a3-a190-ffda44558658"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("40aa54eb-3398-41f6-b6ca-c53a4138498a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "id",
                keyValue: new Guid("c747616a-05bf-46a8-a1b0-cf55dde94931"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("24798d7f-bda3-4fcb-9a95-c1effa3bf07e"), "5-A" },
                    { new Guid("c2b531cd-08c1-4f86-b922-efdddbace473"), "29-B" },
                    { new Guid("b317409b-4663-43f5-ab8e-bbf6c6ca36f7"), "10" },
                    { new Guid("d3485256-2e7f-41b9-b7f8-0efb0bdf056c"), "22-C" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("c747616a-05bf-46a8-a1b0-cf55dde94931"), "Информационных технологий" },
                    { new Guid("303b1933-8f58-42c4-8535-51820e4a2571"), "Радиоэлектроники" },
                    { new Guid("40aa54eb-3398-41f6-b6ca-c53a4138498a"), "Электротехники" },
                    { new Guid("39d05296-9691-42a3-a190-ffda44558658"), "Ядерной физики" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("8182e4fc-cd26-42c5-ba97-b7de0c3af9ff"), "Программирования" },
                    { new Guid("63189e90-5c7e-40dc-bf5f-c04b58731d42"), "Администрирования" },
                    { new Guid("3d149501-5e31-46de-bae2-b20d4d09ea19"), "Дизайна и графики" },
                    { new Guid("ba9cf275-a11f-4459-af20-7d04072112e8"), "Базовый" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ebb940d4-b91b-4a06-b17b-c90bf0b8ea34", "f3638a0f-8cf5-4b2e-82d1-439e70cf1b61", "Administrators", "ADMINISTRATORS" },
                    { "8c5fec19-0be4-4e93-b427-79e111a48d3f", "9b932985-0648-48ea-884f-5ceca7085df0", "Moderators", "MODERATORS" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "id", "departmentId", "firstName", "lastName" },
                values: new object[,]
                {
                    { new Guid("8eec3c13-3619-41a0-911e-b90e442d5152"), new Guid("c747616a-05bf-46a8-a1b0-cf55dde94931"), "Василий", "Петренко" },
                    { new Guid("0b90c34f-bfce-49f5-9e9b-bbb78d1161f9"), new Guid("c747616a-05bf-46a8-a1b0-cf55dde94931"), "Андрей", "Пилипенко" },
                    { new Guid("4dc242eb-2875-43ee-883b-7faf9a8a4127"), new Guid("303b1933-8f58-42c4-8535-51820e4a2571"), "Алексей", "Затворницкий" },
                    { new Guid("75839303-cf6e-4be0-a200-ab84469b1ed1"), new Guid("40aa54eb-3398-41f6-b6ca-c53a4138498a"), "Геннадий", "Узелков" },
                    { new Guid("89feda8e-e81f-4ee2-81c8-ddc788a07f73"), new Guid("39d05296-9691-42a3-a190-ffda44558658"), "Александр", "Усик" }
                });
        }
    }
}

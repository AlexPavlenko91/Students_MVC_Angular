using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class addedTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("04022fb1-a30b-4974-a522-37646f0e2b33"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("36df3a71-9694-4e9c-a7bb-9fbad0bd9f04"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("dce2a480-1199-4373-bef4-f41a68ec1c93"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "id",
                keyValue: new Guid("fe1b70c5-80ba-462e-bf12-63a8b5609215"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("431caae5-9df6-4e11-83c0-d8afd6a650ad"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("9380524d-2a05-4050-9569-edde006f3dc1"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("be150254-0ff5-415b-a862-1e66a198e5ba"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "id",
                keyValue: new Guid("c653e024-b067-4457-bf96-093f3445e734"));

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6b612dce-7339-4c1f-abd0-45f410926c4e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "828ad69a-7591-4e95-a2c0-02e2549b1c55");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("dce2a480-1199-4373-bef4-f41a68ec1c93"), "5-A" },
                    { new Guid("36df3a71-9694-4e9c-a7bb-9fbad0bd9f04"), "29-B" },
                    { new Guid("fe1b70c5-80ba-462e-bf12-63a8b5609215"), "10" },
                    { new Guid("04022fb1-a30b-4974-a522-37646f0e2b33"), "22-C" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("c653e024-b067-4457-bf96-093f3445e734"), "Программирования" },
                    { new Guid("9380524d-2a05-4050-9569-edde006f3dc1"), "Администрирования" },
                    { new Guid("be150254-0ff5-415b-a862-1e66a198e5ba"), "Дизайна и графики" },
                    { new Guid("431caae5-9df6-4e11-83c0-d8afd6a650ad"), "Базовый" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b612dce-7339-4c1f-abd0-45f410926c4e", "fcf45d19-be3c-46d5-a522-e4fea7af4bb5", "Administrators", "ADMINISTRATORS" },
                    { "828ad69a-7591-4e95-a2c0-02e2549b1c55", "653c0405-956b-491b-ab5d-2f1e280a5e28", "Moderators", "MODERATORS" }
                });
        }
    }
}

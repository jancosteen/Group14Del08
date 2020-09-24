using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class dbfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "User_Employee_FK",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "Order_Line_User_FK",
                table: "Order_Line");

            migrationBuilder.DropForeignKey(
                name: "Reservation_User_FK",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "Restaurant_Social_Media_FK",
                table: "Restaurant");

            migrationBuilder.DropForeignKey(
                name: "Star_Rating_User_Comment_FK",
                table: "Star_Rating");

            migrationBuilder.DropForeignKey(
                name: "User_UserImage_User_FK",
                table: "User_UserImage");

            migrationBuilder.DropForeignKey(
                name: "User_UserRole_User_FK",
                table: "User_UserRole");

            migrationBuilder.DropTable(
                name: "Restaurant_Restaurant_Image");

            migrationBuilder.DropIndex(
                name: "IX_Star_Rating_User_Comment_Id_FK",
                table: "Star_Rating");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_Social_Media_Id_FK_Social_Media_Type_Id_FK_FK",
                table: "Restaurant");

            migrationBuilder.DropPrimaryKey(
                name: "User_PK",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UX_Table_1_Email",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Employee_Id_FK",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UX_Table_1_Id",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UX_Table_1_Username",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "User_Comment_Id_FK",
                table: "Star_Rating");

            migrationBuilder.DropColumn(
                name: "Restaurant_Id_FK",
                table: "Restaurant_Status");

            migrationBuilder.DropColumn(
                name: "QrCode_Id_FK",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Social_Media_Type_Id_FK_FK",
                table: "Restaurant");

            migrationBuilder.RenameColumn(
                name: "Employee_Id_FK",
                table: "AspNetUsers",
                newName: "EmployeeIdFk");

            migrationBuilder.RenameColumn(
                name: "Contact_Number",
                table: "AspNetUsers",
                newName: "ContactNumber");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image_File",
                table: "UserImage",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "image");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "User_UserRole",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "User_UserImage",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Star_Rating_Id_Fk",
                table: "User_Comment",
                nullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image_File",
                table: "Restaurant_Image",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "image",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reservation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Order_Line",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Menu_Item_Price_Status",
                table: "Menu_Item_Price",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeIdFkNavigationEmployeeId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Advertisement_File",
                table: "Advertisement",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "image",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles1",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers1",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(unicode: false, nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Surname = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Contact_Number = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Employee_Id_FK = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("User_PK", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "User_Employee_FK",
                        column: x => x.Employee_Id_FK,
                        principalTable: "Employee",
                        principalColumn: "Employee_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims1_AspNetRoles1_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims1_AspNetUsers1_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins1",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins1", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins1_AspNetUsers1_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles1",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles1", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles1_AspNetRoles1_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles1_AspNetUsers1_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens1",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens1", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens1_AspNetUsers1_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_UserRole_UserId",
                table: "User_UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserImage_UserId",
                table: "User_UserImage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Comment_Star_Rating_Id_Fk",
                table: "User_Comment",
                column: "Star_Rating_Id_Fk");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Line_UserId",
                table: "Order_Line",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeeIdFkNavigationEmployeeId",
                table: "AspNetUsers",
                column: "EmployeeIdFkNavigationEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims1_RoleId",
                table: "AspNetRoleClaims1",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles1",
                column: "NormalizedName",
                unique: true,
                filter: "([NormalizedName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims1_UserId",
                table: "AspNetUserClaims1",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins1_UserId",
                table: "AspNetUserLogins1",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles1_RoleId",
                table: "AspNetUserRoles1",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UX_Table_1_Email",
                table: "AspNetUsers1",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers1_Employee_Id_FK",
                table: "AspNetUsers1",
                column: "Employee_Id_FK");

            migrationBuilder.CreateIndex(
                name: "UX_Table_1_Id",
                table: "AspNetUsers1",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers1",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers1",
                column: "NormalizedUserName",
                unique: true,
                filter: "([NormalizedUserName] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "UX_Table_1_Username",
                table: "AspNetUsers1",
                column: "UserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employee_EmployeeIdFkNavigationEmployeeId",
                table: "AspNetUsers",
                column: "EmployeeIdFkNavigationEmployeeId",
                principalTable: "Employee",
                principalColumn: "Employee_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Line_AspNetUsers_UserId",
                table: "Order_Line",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Order_Line_User_FK",
                table: "Order_Line",
                column: "User_Id_FK",
                principalTable: "AspNetUsers1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AspNetUsers_UserId",
                table: "Reservation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Reservation_User_FK",
                table: "Reservation",
                column: "User_Id_FK",
                principalTable: "AspNetUsers1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Comment_Star_Rating",
                table: "User_Comment",
                column: "Star_Rating_Id_Fk",
                principalTable: "Star_Rating",
                principalColumn: "Star_Rating_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserImage_AspNetUsers_UserId",
                table: "User_UserImage",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "User_UserImage_User_FK",
                table: "User_UserImage",
                column: "User_Id_FK",
                principalTable: "AspNetUsers1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserRole_AspNetUsers_UserId",
                table: "User_UserRole",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "User_UserRole_User_FK",
                table: "User_UserRole",
                column: "User_Id_FK",
                principalTable: "AspNetUsers1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employee_EmployeeIdFkNavigationEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Line_AspNetUsers_UserId",
                table: "Order_Line");

            migrationBuilder.DropForeignKey(
                name: "Order_Line_User_FK",
                table: "Order_Line");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AspNetUsers_UserId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "Reservation_User_FK",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Comment_Star_Rating",
                table: "User_Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserImage_AspNetUsers_UserId",
                table: "User_UserImage");

            migrationBuilder.DropForeignKey(
                name: "User_UserImage_User_FK",
                table: "User_UserImage");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserRole_AspNetUsers_UserId",
                table: "User_UserRole");

            migrationBuilder.DropForeignKey(
                name: "User_UserRole_User_FK",
                table: "User_UserRole");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims1");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims1");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins1");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles1");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens1");

            migrationBuilder.DropTable(
                name: "AspNetRoles1");

            migrationBuilder.DropTable(
                name: "AspNetUsers1");

            migrationBuilder.DropIndex(
                name: "IX_User_UserRole_UserId",
                table: "User_UserRole");

            migrationBuilder.DropIndex(
                name: "IX_User_UserImage_UserId",
                table: "User_UserImage");

            migrationBuilder.DropIndex(
                name: "IX_User_Comment_Star_Rating_Id_Fk",
                table: "User_Comment");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Order_Line_UserId",
                table: "Order_Line");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmployeeIdFkNavigationEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User_UserRole");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User_UserImage");

            migrationBuilder.DropColumn(
                name: "Star_Rating_Id_Fk",
                table: "User_Comment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Order_Line");

            migrationBuilder.DropColumn(
                name: "Menu_Item_Price_Status",
                table: "Menu_Item_Price");

            migrationBuilder.DropColumn(
                name: "EmployeeIdFkNavigationEmployeeId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "EmployeeIdFk",
                table: "AspNetUsers",
                newName: "Employee_Id_FK");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "AspNetUsers",
                newName: "Contact_Number");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image_File",
                table: "UserImage",
                type: "image",
                nullable: false,
                oldClrType: typeof(byte[]));

            migrationBuilder.AddColumn<int>(
                name: "User_Comment_Id_FK",
                table: "Star_Rating",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Restaurant_Id_FK",
                table: "Restaurant_Status",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image_File",
                table: "Restaurant_Image",
                type: "image",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QrCode_Id_FK",
                table: "Restaurant",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Social_Media_Type_Id_FK_FK",
                table: "Restaurant",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "AspNetUsers",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Contact_Number",
                table: "AspNetUsers",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Advertisement_File",
                table: "Advertisement",
                type: "image",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "User_PK",
                table: "AspNetUsers",
                column: "Id")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateTable(
                name: "Restaurant_Restaurant_Image",
                columns: table => new
                {
                    Restaurant_Restaurant_Image_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Restaurant_Id_FK = table.Column<int>(type: "int", nullable: false),
                    Restaurant_Image_Id_FK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant_Restaurant_Image_Restaurant_Restaurant_Image_Id", x => x.Restaurant_Restaurant_Image_Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "Restaurant_Restaurant_Image_Restaurant_FK",
                        column: x => x.Restaurant_Id_FK,
                        principalTable: "Restaurant",
                        principalColumn: "Restaurant_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "Restaurant_Restaurant_Image_Restaurant_Image_FK",
                        column: x => x.Restaurant_Image_Id_FK,
                        principalTable: "Restaurant_Image",
                        principalColumn: "Restaurant_Image_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Star_Rating_User_Comment_Id_FK",
                table: "Star_Rating",
                column: "User_Comment_Id_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Social_Media_Id_FK_Social_Media_Type_Id_FK_FK",
                table: "Restaurant",
                columns: new[] { "Social_Media_Id_FK", "Social_Media_Type_Id_FK_FK" });

            migrationBuilder.CreateIndex(
                name: "UX_Table_1_Email",
                table: "AspNetUsers",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Employee_Id_FK",
                table: "AspNetUsers",
                column: "Employee_Id_FK");

            migrationBuilder.CreateIndex(
                name: "UX_Table_1_Id",
                table: "AspNetUsers",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UX_Table_1_Username",
                table: "AspNetUsers",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Restaurant_Image_Restaurant_Id_FK",
                table: "Restaurant_Restaurant_Image",
                column: "Restaurant_Id_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Restaurant_Image_Restaurant_Image_Id_FK",
                table: "Restaurant_Restaurant_Image",
                column: "Restaurant_Image_Id_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Restaurant_Image_Restaurant_Restaurant_Image_Id",
                table: "Restaurant_Restaurant_Image",
                column: "Restaurant_Restaurant_Image_Id");

            migrationBuilder.AddForeignKey(
                name: "User_Employee_FK",
                table: "AspNetUsers",
                column: "Employee_Id_FK",
                principalTable: "Employee",
                principalColumn: "Employee_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Order_Line_User_FK",
                table: "Order_Line",
                column: "User_Id_FK",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Reservation_User_FK",
                table: "Reservation",
                column: "User_Id_FK",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Restaurant_Social_Media_FK",
                table: "Restaurant",
                columns: new[] { "Social_Media_Id_FK", "Social_Media_Type_Id_FK_FK" },
                principalTable: "Social_Media",
                principalColumns: new[] { "Social_Media_Id", "Social_Media_Type_Id_FK" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "Star_Rating_User_Comment_FK",
                table: "Star_Rating",
                column: "User_Comment_Id_FK",
                principalTable: "User_Comment",
                principalColumn: "User_Comment_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "User_UserImage_User_FK",
                table: "User_UserImage",
                column: "User_Id_FK",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "User_UserRole_User_FK",
                table: "User_UserRole",
                column: "User_Id_FK",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

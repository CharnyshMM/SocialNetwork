using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class renaming_usrID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_DialogModel_DialogID",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDialogModel_DialogModel_DialogID",
                table: "UserDialogModel");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDialogModel_Users_UserID",
                table: "UserDialogModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDialogModel",
                table: "UserDialogModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DialogModel",
                table: "DialogModel");

            migrationBuilder.RenameTable(
                name: "UserDialogModel",
                newName: "UserDialogs");

            migrationBuilder.RenameTable(
                name: "DialogModel",
                newName: "Dialogs");

            migrationBuilder.RenameIndex(
                name: "IX_UserDialogModel_DialogID",
                table: "UserDialogs",
                newName: "IX_UserDialogs_DialogID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDialogs",
                table: "UserDialogs",
                columns: new[] { "UserID", "DialogID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dialogs",
                table: "Dialogs",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Dialogs_DialogID",
                table: "Messages",
                column: "DialogID",
                principalTable: "Dialogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDialogs_Dialogs_DialogID",
                table: "UserDialogs",
                column: "DialogID",
                principalTable: "Dialogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDialogs_Users_UserID",
                table: "UserDialogs",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Dialogs_DialogID",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDialogs_Dialogs_DialogID",
                table: "UserDialogs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDialogs_Users_UserID",
                table: "UserDialogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDialogs",
                table: "UserDialogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dialogs",
                table: "Dialogs");

            migrationBuilder.RenameTable(
                name: "UserDialogs",
                newName: "UserDialogModel");

            migrationBuilder.RenameTable(
                name: "Dialogs",
                newName: "DialogModel");

            migrationBuilder.RenameIndex(
                name: "IX_UserDialogs_DialogID",
                table: "UserDialogModel",
                newName: "IX_UserDialogModel_DialogID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDialogModel",
                table: "UserDialogModel",
                columns: new[] { "UserID", "DialogID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DialogModel",
                table: "DialogModel",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_DialogModel_DialogID",
                table: "Messages",
                column: "DialogID",
                principalTable: "DialogModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDialogModel_DialogModel_DialogID",
                table: "UserDialogModel",
                column: "DialogID",
                principalTable: "DialogModel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDialogModel_Users_UserID",
                table: "UserDialogModel",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

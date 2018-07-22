using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetNote.MVC6.Migrations
{
    public partial class NoteCommentsFKadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_NoteComments_UserNo",
                table: "NoteComments",
                column: "UserNo");

            migrationBuilder.AddForeignKey(
                name: "FK_NoteComments_Users_UserNo",
                table: "NoteComments",
                column: "UserNo",
                principalTable: "Users",
                principalColumn: "UserNo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NoteComments_Users_UserNo",
                table: "NoteComments");

            migrationBuilder.DropIndex(
                name: "IX_NoteComments_UserNo",
                table: "NoteComments");
        }
    }
}

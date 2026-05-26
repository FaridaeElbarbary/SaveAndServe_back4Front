using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class InitialClean : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // مسحنا كل حاجة عشان ميعملش تعارض مع الجداول الموجودة
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // مسحنا كل حاجة
        }
    }
}
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Companies(Name) values ('Company 1')");
            migrationBuilder.Sql("Insert into Companies(Name) values ('Company 2')");
            migrationBuilder.Sql("Insert into Companies(Name) values ('Company 3')");

            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 1-ModelA',(select Id from Companies where Name='Company 1'))");
            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 1-ModelB',(select Id from Companies where Name='Company 1'))");
            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 1-ModelC',(select Id from Companies where Name='Company 1'))");

            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 2-ModelA',(select Id from Companies where Name='Company 2'))");
            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 2-ModelB',(select Id from Companies where Name='Company 2'))");
            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 2-ModelC',(select Id from Companies where Name='Company 2'))");

            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 3-ModelA',(select Id from Companies where Name='Company 3'))");
            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 3-ModelB',(select Id from Companies where Name='Company 3'))");
            migrationBuilder.Sql("Insert into Models (Name, CompanyId) values ('Company 3-ModelC',(select Id from Companies where Name='Company 3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Companies");
        }
    }
}

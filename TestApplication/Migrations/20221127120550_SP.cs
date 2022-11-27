using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApplication.Migrations
{
    public partial class SP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[AddToQueue]
                    @FullName varchar(50), @Number int, @CheckInDate datetime, @Status int
                AS
                BEGIN
                    Insert into Users (Number, FullName, CheckInDate, Status) values (@Number, @FullName, @CheckInDate, @Status)
                    Update Users Set Status = 2 where Status = 1
                    
                    Update Users Set Status = 1 where id in (Select Top 1 Id from Users where Status = 0 order by CheckInDate desc)
                    
                END";
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorAppEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A deep dive into distributed ledgers, consensus protocols, smart contracts, DApps, cryptocurrencies, Ethereum, and more 3rd ed. Edition", "https://m.media-amazon.com/images/I/71sZn444OfL._SL1360_.jpg", 9.99m, "Mastering Blockchain - Third Edition" },
                    { 2, "A Guide to the Cloud for SQL Server Professionals 1st ed. Edition, Kindle Edition", "https://m.media-amazon.com/images/I/61kXeAWGSbL._SL1180_.jpg", 90.99m, "Azure SQL Revealed" },
                    { 3, "An interactive learning experience: Comprehensive introduction to data structures and algorithms (Spanish Edition) Kindle Edition", "https://m.media-amazon.com/images/I/81Xp21sgKIL._SL1500_.jpg", 19.99m, "Algorithms and Data Structures with Python" },
                    { 4, "System design questions are often the most difficult of all technical interview questions. This book makes them easier to tackle. It is Volume 1 of the ‘System Design Interview - An Insider’s Guide’ series", "https://m.media-amazon.com/images/I/615KGTRs1OL._SL1500_.jpg", 39.99m, "System Design Interview" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

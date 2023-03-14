using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "KaderKutusu");

            migrationBuilder.CreateTable(
                name: "DogalTas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Isim = table.Column<string>(type: "text", nullable: false),
                    Ozellikler = table.Column<string>(type: "text", nullable: false),
                    Maliyet = table.Column<decimal>(type: "numeric", nullable: false),
                    OrtalamaAgirlik = table.Column<decimal>(type: "numeric", nullable: false),
                    Stok = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogalTas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "KaderKutusu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdSoyad = table.Column<string>(type: "text", nullable: false),
                    Yas = table.Column<string>(type: "text", nullable: false),
                    EPosta = table.Column<string>(type: "text", nullable: false),
                    Adres = table.Column<string>(type: "text", nullable: false),
                    Sifre = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    OnaylandiMi = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sepet_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "KaderKutusu",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KaderKutusu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SepetId = table.Column<int>(type: "integer", nullable: false),
                    KaderTasId = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KaderKutusu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KaderKutusu_DogalTas_KaderTasId",
                        column: x => x.KaderTasId,
                        principalTable: "DogalTas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KaderKutusu_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kutu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tur = table.Column<string>(type: "text", nullable: false),
                    UrunKodu = table.Column<string>(type: "text", nullable: false),
                    Fiyat = table.Column<decimal>(type: "numeric", nullable: false),
                    SepetId = table.Column<int>(type: "integer", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kutu_Sepet_SepetId",
                        column: x => x.SepetId,
                        principalTable: "Sepet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DogalTasKutu",
                columns: table => new
                {
                    BulunduguKutularId = table.Column<int>(type: "integer", nullable: false),
                    IcerikId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogalTasKutu", x => new { x.BulunduguKutularId, x.IcerikId });
                    table.ForeignKey(
                        name: "FK_DogalTasKutu_DogalTas_IcerikId",
                        column: x => x.IcerikId,
                        principalTable: "DogalTas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogalTasKutu_Kutu_BulunduguKutularId",
                        column: x => x.BulunduguKutularId,
                        principalTable: "Kutu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "KaderKutusu",
                table: "User",
                columns: new[] { "Id", "AdSoyad", "Adres", "CreateDate", "EPosta", "Sifre", "Yas" },
                values: new object[] { 1, " Selda Bağcan", "Konak mah. 312. Cd. 123. sk İzmir Türkiye", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vurucusesselda@yahoo.com", "123456", "64" });

            migrationBuilder.CreateIndex(
                name: "IX_DogalTasKutu_IcerikId",
                table: "DogalTasKutu",
                column: "IcerikId");

            migrationBuilder.CreateIndex(
                name: "IX_KaderKutusu_KaderTasId",
                table: "KaderKutusu",
                column: "KaderTasId");

            migrationBuilder.CreateIndex(
                name: "IX_KaderKutusu_SepetId",
                table: "KaderKutusu",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_Kutu_SepetId",
                table: "Kutu",
                column: "SepetId");

            migrationBuilder.CreateIndex(
                name: "IX_Sepet_UserId",
                table: "Sepet",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogalTasKutu");

            migrationBuilder.DropTable(
                name: "KaderKutusu");

            migrationBuilder.DropTable(
                name: "Kutu");

            migrationBuilder.DropTable(
                name: "DogalTas");

            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropTable(
                name: "User",
                schema: "KaderKutusu");
        }
    }
}

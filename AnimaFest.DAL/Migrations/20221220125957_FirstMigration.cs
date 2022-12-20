using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimaFest.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gasolinas",
                columns: table => new
                {
                    DataInsercao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrecoPorLitro = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasolinas", x => x.DataInsercao);
                });

            migrationBuilder.CreateTable(
                name: "TipoGastos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoGastos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alocacaoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ValorTotalAlugado = table.Column<float>(type: "real", nullable: false),
                    DataInicialAlugada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinalAlugada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PagoEmGasolina = table.Column<float>(type: "real", nullable: false),
                    QuantKMRodado = table.Column<float>(type: "real", maxLength: 200, nullable: false),
                    CidadeAlugadaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alocacaoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alocacaoes_Cidades_CidadeAlugadaId",
                        column: x => x.CidadeAlugadaId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecoMedioAluguel = table.Column<float>(type: "real", nullable: true),
                    Alugavel = table.Column<bool>(type: "bit", nullable: false),
                    AlocacaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Alocacaoes_AlocacaoId",
                        column: x => x.AlocacaoId,
                        principalTable: "Alocacaoes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorGastado = table.Column<float>(type: "real", maxLength: 200, nullable: false),
                    TipoGastoId = table.Column<int>(type: "int", nullable: false),
                    AlocacaoId = table.Column<int>(type: "int", nullable: true),
                    ProdutoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gastos_Alocacaoes_AlocacaoId",
                        column: x => x.AlocacaoId,
                        principalTable: "Alocacaoes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Gastos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Gastos_TipoGastos_TipoGastoId",
                        column: x => x.TipoGastoId,
                        principalTable: "TipoGastos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alocacaoes_CidadeAlugadaId",
                table: "Alocacaoes",
                column: "CidadeAlugadaId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_AlocacaoId",
                table: "Gastos",
                column: "AlocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_ProdutoId",
                table: "Gastos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_TipoGastoId",
                table: "Gastos",
                column: "TipoGastoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_AlocacaoId",
                table: "Produtos",
                column: "AlocacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gasolinas");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "TipoGastos");

            migrationBuilder.DropTable(
                name: "Alocacaoes");

            migrationBuilder.DropTable(
                name: "Cidades");
        }
    }
}

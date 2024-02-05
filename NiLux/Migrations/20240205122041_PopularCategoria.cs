using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiLux.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES ('Almoco', 'Evento acontece durante o almoco')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES ('Jantar', 'Evento acontece durante o jantar')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES ('Cruzeiro', 'Evento e um cruzeiro')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES ('Trilha', 'Evento e uma trilha')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES ('Experiencia', 'Evento e uma experiencia, usado quando nao entrar em outra categoria')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES ('Aula', 'Evento e uma aula com profissional renomado')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES ('Jogo', 'Evento e um jogo, ou participacao em um jogo')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}

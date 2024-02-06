using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NiLux.Migrations
{
    /// <inheritdoc />
    public partial class PopularEventos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Eventos (NomeEvento,DescricaoCurta,DescricaoLonga,Preco,ImagemURL,ImagemTumbnailURL,EventoPreferido,EmEstoque,CategoriaId) " +
                "VALUES ('Jantar com Nicolas Cage','Desfrute de uma experiência única e inesquecível em um jantar privativo com o ator Nicolas Cage.','Desfrute de uma experiência única e inesquecível em um jantar privativo com o renomado ator Nicolas Cage. Este evento exclusivo é projetado para apenas cinco sortudos convidados que terão a oportunidade de compartilhar uma noite íntima e descontraída com uma das lendas de Hollywood. Este jantar exclusivo oferece a oportunidade de não apenas desfrutar de uma refeição gourmet e ambiente requintado, mas também de compartilhar momentos especiais com uma das figuras mais icônicas da indústria cinematográfica. Não perca a chance de participar desta experiência única e tornar seu jantar uma verdadeira celebração cinematográfica. Garanta seu lugar neste evento inigualável!',29.697,'https://s.yimg.com/ny/api/res/1.2/5IgtmO9pmoOLt_bvhUpiqg--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTQ5MQ--/https://media-mbst-pub-ue1.s3.amazonaws.com/creatr-images/2020-02/433484c0-53db-11ea-bdd7-8329d5f8b7e7', 'https://s.yimg.com/ny/api/res/1.2/5IgtmO9pmoOLt_bvhUpiqg--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTQ5MQ--/https://media-mbst-pub-ue1.s3.amazonaws.com/creatr-images/2020-02/433484c0-53db-11ea-bdd7-8329d5f8b7e7',1,0,9)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Eventos");
        }
    }
}

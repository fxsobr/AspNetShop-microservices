using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetShop.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Estratégia", "Crie a sua escola dos sonhos neste jogo de simulação de gerenciamento! A escola está te deixando para baixo?", "https://cdn.cloudflare.steamstatic.com/steam/apps/1921760/header.jpg?t=1655089737", "Pocket Academy", 16.73m },
                    { 3L, "Casual", "Um jogo de trabalho em equipe e trairagem online ou em rede local para 4 a 15 jogadores... no espaço!", "https://cdn.cloudflare.steamstatic.com/steam/apps/945360/header.jpg?t=1646296970", "Among Us", 18.71m },
                    { 4L, "Ação", "AS MELHORES LUTAS SÃO AS PESSOAIS Cerre os punhos e se prepare para o combate definitivo.", "https://cdn.cloudflare.steamstatic.com/steam/apps/389730/header.jpg?t=1638999755", "Tekken 7", 16.73m },
                    { 5L, "FPS", "O Counter-Strike: Global Offensive (CS:GO) melhora a jogabilidade de ação baseada em equipes na qual foi pioneiro quando lançado há 19 anos. O CS:GO contém novos mapas, personagens e armas, além de contar com versões atualizadas de conteúdos do CS clássico (como de_dust2).", "https://cdn.cloudflare.steamstatic.com/steam/apps/730/header.jpg?t=1641233427", "Counter-Strike: Global Offensive", 75.99m },
                    { 6L, "Ação", "O NOVO RPG DE AÇÃO E FANTASIA. Levante-se, Maculado, e seja guiado pela graça para portar o poder do Anel Prístino e se tornar um Lorde Prístino nas Terras Intermédias.", "https://cdn.cloudflare.steamstatic.com/steam/apps/1245620/header.jpg?t=1654259241", "ELDEN RING", 249.9m },
                    { 7L, "MMORPG", "Boas-vindas a High Isle, uma parte de Tamriel nunca antes vista em The Elder Scrolls. Explore o idílico enclave oceânico dos bretões e sede da cultura cavalheiresca ao confrontar as forças destruidoras do Senhor Ascendente.", "https://cdn.cloudflare.steamstatic.com/steam/apps/1754000/header_brazilian.jpg?t=1654630255", "The Elder Scrolls Online: High Isle", 149m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);
        }
    }
}

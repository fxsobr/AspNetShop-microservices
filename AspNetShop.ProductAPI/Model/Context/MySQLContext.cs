using Microsoft.EntityFrameworkCore;

namespace AspNetShop.ProductAPI.Model.Context;

public class MySQLContext : DbContext
{
    public MySQLContext() {}

    public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}
    
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 2,
            Name = "Pocket Academy",
            Price = new decimal(16.73),
            Description = "Crie a sua escola dos sonhos neste jogo de simulação de gerenciamento! " +
                          "A escola está te deixando para baixo?",
            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/1921760/header.jpg?t=1655089737",
            CategoryName = "Estratégia"
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 3,
            Name = "Among Us",
            Price = new decimal(18.71),
            Description = "Um jogo de trabalho em equipe e trairagem online ou em rede local para 4 a 15 jogadores..." +
                          " no espaço!",
            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/945360/header.jpg?t=1646296970",
            CategoryName = "Casual"
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 4,
            Name = "Tekken 7",
            Price = new decimal(16.73),
            Description = "AS MELHORES LUTAS SÃO AS PESSOAIS Cerre os punhos e se prepare para o combate definitivo.",
            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/389730/header.jpg?t=1638999755",
            CategoryName = "Ação"
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 5,
            Name = "Counter-Strike: Global Offensive",
            Price = new decimal(75.99),
            Description = "O Counter-Strike: Global Offensive (CS:GO) melhora a jogabilidade de ação baseada em equipes " +
                          "na qual foi pioneiro quando lançado há 19 anos. O CS:GO contém novos mapas, personagens e " +
                          "armas, além de contar com versões atualizadas de conteúdos do CS clássico (como de_dust2).",
            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/730/header.jpg?t=1641233427",
            CategoryName = "FPS"
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 6,
            Name = "ELDEN RING",
            Price = new decimal(249.90),
            Description = "O NOVO RPG DE AÇÃO E FANTASIA. Levante-se, Maculado, e seja guiado pela graça para portar o " +
                          "poder do Anel Prístino e se tornar um Lorde Prístino nas Terras Intermédias.",
            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/1245620/header.jpg?t=1654259241",
            CategoryName = "Ação"
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 7,
            Name = "The Elder Scrolls Online: High Isle",
            Price = new decimal(149.00),
            Description = "Boas-vindas a High Isle, uma parte de Tamriel nunca antes vista em The Elder Scrolls. " +
                          "Explore o idílico enclave oceânico dos bretões e sede da cultura cavalheiresca ao " +
                          "confrontar as forças destruidoras do Senhor Ascendente.",
            ImageUrl = "https://cdn.cloudflare.steamstatic.com/steam/apps/1754000/header_brazilian.jpg?t=1654630255",
            CategoryName = "MMORPG"
        });
    }

}
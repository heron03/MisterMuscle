
using Microsoft.EntityFrameworkCore;

using ProjetoIntegrador.Shared;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder mb)
    {
      mb.Entity<ProdutoPedido>()
        .HasKey(pp => new {pp.PedidoId, pp.ProdutoId});
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Estoque> Estoques { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<NotaFiscal> NotaFiscais { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoPedido> ProdutoPedidos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}
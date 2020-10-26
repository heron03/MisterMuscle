
using Microsoft.EntityFrameworkCore;

using ProjetoIntegrador.Shared;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
    {
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Estoque> Estoques { get; set; }
    public DbSet<Fornecedor> Fornecedors { get; set; }
    public DbSet<NotaFiscal> NotaFiscals { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoPedido> ProdutoPedidos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}
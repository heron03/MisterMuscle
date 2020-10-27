using ProjetoIntegrador.Server;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class ProductController : Controller
{
    private readonly AppDbContext db;

    public ProductController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var produtos = await db.Produtos.ToListAsync();
        return Ok(produtos);
    }

    

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Produto produto)
    {
        try
        {
            var novoProduto = new Produto
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                ImagemProduto = produto.ImagemProduto,
                Quantidade = produto.Quantidade,
                FornecedorId = produto.FornecedorId,
                CategoriaId = produto.CategoriaId,

            };
           


            

            db.Add(novoProduto);
            await db.SaveChangesAsync();//INSERT INTO
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

    [HttpGet]
    [Route("GetId")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        // procura no banco na tabela products se tem algum Id igual e retorna o produto com todas suas informações
        var produto = await db.Produtos.SingleOrDefaultAsync(p => p.Id == Convert.ToInt32(id));
        return Ok(produto);
    }

    
    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Put([FromBody] Produto produto)
    {
        if (!ModelState.IsValid){

            return BadRequest(ModelState);

        }

        db.Entry(produto).State = EntityState.Modified;
        try
        {
            await db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw (ex);
        }
        return NoContent();
    }


    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<ActionResult <Usuario>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var produto = await db.Produtos.FindAsync(id);
        if(produto == null)
        {
            return NotFound();
        }

        db.Produtos.Remove(produto);
        await db.SaveChangesAsync();
        return Ok(produto);
    }

}
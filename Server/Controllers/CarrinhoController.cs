using ProjetoIntegrador.Server;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class CarrinhoController : Controller
{
    private readonly AppDbContext db;

    public CarrinhoController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get()
    {
        var carrinhos = await db.Carrinhos.ToListAsync();
        return Ok(carrinhos);

    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Carrinho carrinho)
    {
        try
        {
            var novoCarrinho = new Carrinho
            {
                UsuarioId = carrinho.UsuarioId,
                ProdutoId = carrinho.ProdutoId,

            };

            db.Add(novoCarrinho);
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
        var carrinho = await db.Carrinhos.SingleOrDefaultAsync(carrinho => carrinho.UsuarioId == Convert.ToInt32(id));
        return Ok(carrinho);
    }


    [HttpPut]
    [Route("Update")]
    public async Task<IActionResult> Put([FromBody] Carrinho carrinho)
    {
        if (!ModelState.IsValid)
        {

            return BadRequest(ModelState);

        }

        db.Entry(carrinho).State = EntityState.Modified;
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
    public async Task<ActionResult<Carrinho>> Delete(int id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var carrinho = await db.Carrinhos.FindAsync(id);
        if (carrinho == null)
        {
            return NotFound();
        }

        db.Carrinhos.Remove(carrinho);
        await db.SaveChangesAsync();
        return Ok(carrinho);
    }

}
using ProjetoIntegrador.Server;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Shared;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography;

[ApiController]
[Route("[controller]")]
public class UsuarioController : Controller
{
    private readonly AppDbContext db;

    public UsuarioController(AppDbContext db)
    {
        this.db = db;
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Usuario usuario)
    {
        try
        {
            var newUsuario = new Usuario
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Cpf = usuario.Cpf,
                Senha = usuario.Senha,
                Celular = usuario.Celular,
                Confirmarsenha = usuario.Confirmarsenha,
            };

            db.Add(newUsuario);
            await db.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }
}
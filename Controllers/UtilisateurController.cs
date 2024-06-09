using EntityFrameworkCoreMySQL.Data;
using EntityFrameworkCoreMySQL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public UtilisateurController(AppDbContext appDbcontext) 
        {
            _appDbContext = appDbcontext;
        }
        // ajouter un utilisateur post
        [HttpPost]
        public async Task<IActionResult> AddUtilisateur(Utilisateur utilisateur) 
        {
            _appDbContext.Utilisateurs.Add(utilisateur);
            await _appDbContext.SaveChangesAsync();

            return Ok(utilisateur);
        }
        // get 
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var utilisateurs = await _appDbContext.Utilisateurs.ToListAsync();
            return Ok(utilisateurs);
        }
    }

}

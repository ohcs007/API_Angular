using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks;
using CRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;

namespace CRUD.Controllers
{
    //Responsavel pelo HTTP
    [Controller]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private DataContext data;

        public PessoaController(DataContext context) 
        {
            this.data = context;
        }
        //Trabalha em mais camadas
        //Pensar em forma de validar
        //

        [HttpPost("CRUD")]
        public async Task<ActionResult> cadastrar([FromBody] Pessoa p) 
        {
            data.pessoa.Add(p);
            await data.SaveChangesAsync();

            return Created("Objeto pessoa",p);
        }

        [HttpGet("CRUD")]
        public async Task<ActionResult> listar()
        {
            var resultado = await data.pessoa.ToListAsync();
            return Ok(resultado);
        }
        [HttpGet("CRUD/{id}")]
        public Pessoa filtrar(int id)
        {
            Pessoa p = data.pessoa.Find(id);
            return p;
           
        }

        [HttpPut("CRUD")]
        public async Task<ActionResult> editar([FromBody] Pessoa p)
        {
            data.pessoa.Update(p);
            await data.SaveChangesAsync();

            return Ok(p);
        }

        [HttpDelete("CRUD/{id}")]
        public async Task<ActionResult> deletar(int id)
        {


            Pessoa p = filtrar(id);

            if (p == null)
            {
                return NotFound();
            }
            else
            {
                data.pessoa.Remove(p);
                await data.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Data;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly BibliotecaApiContext _context;


        public BibliotecaController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultaLibro()
        {
            return Ok(await _context.Libro.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AgregarLibro(Libro libro)
        {
            _context.Libro.Add(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }
        [HttpPut]
        public async Task<IActionResult> ActualizarLibro(Libro libro)
        {
            _context.Update(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteLibro(Libro libro)
        {
            _context.Remove(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }

        [HttpGet]
        public async Task<IActionResult> ConsultaImagen()
        {
            return Ok(await _context.Imagen.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AgregarImagen(Imagen imagen)
        {
            _context.Imagen.Add(imagen);
            await _context.SaveChangesAsync();
            return Ok(imagen);
        }
        [HttpPut]
        public async Task<IActionResult> ActualizarImagen(Imagen imagen)
        {
            _context.Update(imagen);
            await _context.SaveChangesAsync();
            return Ok(imagen);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteImagen(Imagen imagen)
        {
            _context.Remove(imagen);
            await _context.SaveChangesAsync();
            return Ok(imagen);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBanDoGo.Models;

namespace WebBanDoGo.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly NoiThatDatabaseContext _context;

        public SanPhamController(NoiThatDatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var NoiThatDatabaseContext = _context.SanPhams.Include(s => s.MaDmNavigation);
            return View(await NoiThatDatabaseContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .Include(s => s.MaDmNavigation)
                .FirstOrDefaultAsync(m => m.MaSp == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }

       public async Task<IActionResult> SuaTT()
        {
            var NoiThatDatabaseContext = _context.SanPhams.Include(s => s.MaDmNavigation);
            return View(await NoiThatDatabaseContext.ToListAsync());
        }

        public async Task<IActionResult> SuaChua()
        {
            var NoiThatDatabaseContext = _context.SanPhams.Include(s => s.MaDmNavigation);
            return View(await NoiThatDatabaseContext.ToListAsync());
        }

        public async Task<IActionResult> BoPhomat()
        {
            var NoiThatDatabaseContext = _context.SanPhams.Include(s => s.MaDmNavigation);
            return View(await NoiThatDatabaseContext.ToListAsync());
        }

        public async Task<IActionResult> ViewByLoaiSP(int id)
        {
            var spFillterList = await _context.SanPhams.Where(x => x.MaDm == id).ToListAsync();
            return View(spFillterList);
        }

        private bool SanPhamExists(int id)
        {
            return _context.SanPhams.Any(e => e.MaSp == id);
        }
    }
}

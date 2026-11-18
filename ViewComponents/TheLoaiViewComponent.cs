using PhuongMaiAnh_241224468.Models;
using Microsoft.AspNetCore.Mvc;

namespace PhuongMaiAnh_241224468.ViewComponents
{
    public class TheLoaiViewComponent : ViewComponent
    {
        private readonly QLNhaSachContext _context;

        public TheLoaiViewComponent(QLNhaSachContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var theLoai = _context.TheLoais.ToList();
            return View(theLoai);
        }
    }
}

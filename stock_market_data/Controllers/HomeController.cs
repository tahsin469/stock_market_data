using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using stock_market_data.Models;
using System;
using System.Diagnostics;

namespace stock_market_data.Controllers
{
    public class HomeController : Controller
    {


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly TradeDbContext _context;

        public HomeController(TradeDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public async Task<IActionResult> Index()
        //{
        //    var tradeCodes = await _context.TradeDatas.Select(t => t.TradeCode).Distinct().ToListAsync();
        //    ViewBag.TradeCodes = new SelectList(tradeCodes);
        //    return View(new List<TradeData>());
        //}


        //public async Task<JsonResult> GetTradeData(string tradeCode)
        //{
        //    var data = await _context.TradeDatas.Where(t => t.TradeCode == tradeCode)
        //                                       .OrderBy(t => t.Date)
        //                                       .ToListAsync();
        //    return Json(data);
        //}

        public async Task<IActionResult> Index()
        {
            var trdData = await _context.TradeDatas.ToListAsync(); // Await the ToListAsync() method
            return View(trdData);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TradeData trd)
        {
            if(ModelState.IsValid)
            {
                await _context.TradeDatas.AddAsync(trd);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View(trd);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == null || _context.TradeDatas == null)
            {
                return NotFound();
            }
            var trdData = await _context.TradeDatas.FirstOrDefaultAsync(x => x.Id == id); // Await the ToListAsync() method
            if (trdData == null)
            {
                return NotFound();
            }
            return View(trdData);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var trdData = await _context.TradeDatas.FindAsync(id);
            return View(trdData);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(int id, TradeData trd)
        {
            if (id != trd.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.TradeDatas.Update(trd);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(trd);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TradeDatas == null)
            {
                return NotFound();
            }
            var trdData = await _context.TradeDatas.FirstOrDefaultAsync(x => x.Id == id);
            if (trdData == null)
            {
                return NotFound();
            }
            return View(trdData);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var stdData = await _context.TradeDatas.FindAsync(id);
            if (stdData != null)
            {
                _context.TradeDatas.Remove(stdData);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult TradeData()
        {
            return View();
        }

        [HttpPost]

        public List<object> GetTradeData()
        {
            List<object> data = new List<object>();
            // Convert decimal values to strings for labels
            List<string> labels = _context.TradeDatas.Select(x => x.Close.ToString()).ToList();

            // Convert DateTime values to strings for dates
            List<string> dates = _context.TradeDatas.Select(x => x.Date.ToString()).ToList();
            data.Add(labels);
            data.Add(dates);
            return data;
        }



        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using AjaxGPUProjekt.Models;
using AjaxGPUProjekt.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text.Json;

namespace AjaxGPUProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGpuRepository _repo;

        public HomeController(ILogger<HomeController> logger, IGpuRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index(List<Gpu> gpus)
        {
            gpus = _repo.Gpus.ToList();
            if (gpus.Count() == 0) {
                return View();
            } else {
                return View(gpus);
            }
        }

        [HttpPost("Gpu")]
        public IActionResult Post(Gpu gpu) {
            int rowCount = _repo.Gpus.Count();
            _repo.AddGpu(gpu);

            return View("Index");
        }

        [HttpGet("Gpu")]
        public IActionResult Get() {
            var gpus = _repo.Gpus;
            return Json(gpus);
        }

        [HttpPut("Gpu")]
        public IActionResult Put(Gpu gpu) {
            _repo.UpdateGpu(gpu);

            return View("Index");
        }

        [HttpDelete("Gpu/{id:int}")]
        public IActionResult Delete(int id) {
            _repo.DeleteGpu(id);

            return View("Index");
        }
    }
}

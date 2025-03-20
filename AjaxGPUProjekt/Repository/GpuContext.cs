using AjaxGPUProjekt.Models;
using Microsoft.EntityFrameworkCore;

namespace AjaxGPUProjekt.Repository {
    public class GpuContext : DbContext {
        public GpuContext(DbContextOptions<GpuContext> options) : base(options) { }

        public DbSet<Gpu> Gpus { get; set; }
    }
}

using AjaxGPUProjekt.Models;

namespace AjaxGPUProjekt.Repository {
    public class GpuRepository : IGpuRepository {
        private GpuContext ctx;

        public GpuRepository(GpuContext context) {
            ctx = context;
        }

        public IQueryable<Gpu> Gpus => ctx.Gpus;

        public void AddGpu(Gpu gpu) {
            ctx.Gpus.Add(gpu);
            ctx.SaveChanges();
        }

        public void DeleteGpu(int id) {
            Gpu gpu = ctx.Gpus.Find(id);
            ctx.Gpus.Remove(gpu);

            ctx.SaveChanges();
        }

        public List<Gpu> GetGpus() {
            return ctx.Gpus.ToList<Gpu>();
        }

        public void UpdateGpu(Gpu newGpu) {
            var oldGpu = ctx.Gpus.Find(newGpu.Id);

            oldGpu.Producent = newGpu.Producent;
            oldGpu.Model = newGpu.Model;
            oldGpu.Pris = newGpu.Pris;
            oldGpu.VRam = newGpu.VRam;

            ctx.SaveChanges();
        }
    }
}
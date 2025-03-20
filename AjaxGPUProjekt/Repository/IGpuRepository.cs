using AjaxGPUProjekt.Models;

namespace AjaxGPUProjekt.Repository {
    public interface IGpuRepository {
        IQueryable<Gpu> Gpus { get; }

        public void AddGpu(Gpu gpu);
        public List<Gpu> GetGpus();
        public void UpdateGpu(Gpu newGpu);
        public void DeleteGpu(int id);
    }
}

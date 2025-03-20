namespace AjaxGPUProjekt.Models
{
    public class Gpu
    {
        public int Id { get; set; }
        public string Model {  get; set; }

        public string Producent { get; set; }

        public int Pris {  get; set; }

        public int VRam { get; set; }

        public Gpu() { }

        public Gpu(string model, string producent, int pris, int vram) {
            this.Model = model;
            this.Producent = producent;
            this.Pris = pris;
            this.VRam = vram;
        }
    }
}

namespace ExerciciosASP_NET_CORE_MVC.Models
{
    public class BuscaEventoViewModel
    {
        public string? NomeBusca { get; set; }
        public string? LocalBusca { get; set; }
        public DateTime? DataInicial { get; set; }
        public List<Evento> Resultados { get; set; } = new List<Evento>();
        public bool BuscaRealizada { get; set; }
    }
}
namespace GestionChambre.Models
{
    public class Chambre
    {
        public  int Numero { get; set; }
        public string Type { get; set; } = "chambre simple,double,suite";
        public int Numero_etage { get; set; }
        public DateTime Date_Debut { get; set; }
        public DateTime Date_Fin {  get; set; }

    }
}

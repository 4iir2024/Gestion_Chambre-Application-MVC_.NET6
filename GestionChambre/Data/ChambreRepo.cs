using GestionChambre.Models;

namespace GestionChambre.Data
{
    public class ChambreRepo
    {
        private static List<Chambre> chambres = new List<Chambre>
        {
            new Chambre
            {
                Numero=1,
                Type= "chambre simple",
                Numero_etage=2,
                Date_Debut=new DateTime(2023,02,12),
                Date_Fin=new DateTime(2023,03,12)
            },
             new Chambre
            {
                Numero=2,
                Type= "double",
                Numero_etage=2,
                Date_Debut=new DateTime(2023,02,12),
                Date_Fin=new DateTime(2023,03,12)
            },
             new Chambre
            {
                Numero=3,
                Type= "suite",
                Numero_etage=2,
                Date_Debut=new DateTime(2023,02,12),
                Date_Fin=new DateTime(2023,03,12)
            },

              new Chambre
            {
                Numero=4,
                Type= "chambre simple",
                Numero_etage=1,
                Date_Debut=new DateTime(2023,02,12),
                Date_Fin=new DateTime(2023,03,12)
            },
               new Chambre
            {
                Numero=5,
                Type= "double",
                Numero_etage=4,
                Date_Debut=new DateTime(2023,02,12),
                Date_Fin=new DateTime(2023,03,12)
            },
                new Chambre
            {
                Numero=6,
                Type= "suite",
                Numero_etage=6,
                Date_Debut=new DateTime(2023,02,12),
                Date_Fin=new DateTime(2023,03,12)
            }


        };
        public static List<Chambre> GetChambres() { return chambres; } 
    }
}

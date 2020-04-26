using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBankConsole
{
    class Client
    {
        public Client()
        {
            rekeningen = new List<Rekening>();
        }

        private List<Rekening> rekeningen;
        /// <summary>
        /// De voornaam van de cliënt
        /// </summary>
        public string Voornaam { get; set; }
        /// <summary>
        /// De familienaam van de cliënt
        /// </summary>
        public string Familienaam { get; set; }
        /// <summary>
        /// Het adres van de cliënt
        /// </summary>
        public string Adres { get; set; }
        /// <summary>
        /// De rekeningen van de cliënt
        /// </summary>
        public List<Rekening> Rekeningen
        {
            get { return rekeningen; }
            set { rekeningen = value; }
        }

        /// <summary>
        /// Een rekening openen voor deze cliënt
        /// </summary>
        /// <param name="rekening"></param>
        public void RekeningOpenen(Rekening rekening)
        {
            // Maak deze cliënt houder van de rekening
            rekening.Houder = $"{Voornaam} {Familienaam}";
            // Voeg de rekening toe aan de rekeningen van de cliënt
            rekeningen.Add(rekening);
        }

        /// <summary>
        /// Een rekening van de cliënt afsluiten
        /// </summary>
        /// <param name="rekeningnummer">Het rekeningnummer van de af te sluiten rekening.</param>
        /// <returns>true indien gelukt; false indien niet.</returns>
        public bool RekeningSluiten(string rekeningnummer)
        {
            bool isGelukt = false;
            // Zoek de te sluiten rekening op
            Rekening rekening = RekeningOpzoeken(rekeningnummer);
            // Sluiten indien gevonden
            if(rekening!=null)
            {
                // rekening sluiten = verwijderen uit de lijst
                isGelukt = rekeningen.Remove(rekening);
            }
            return isGelukt;
        }

        /// <summary>
        /// Zoek een rekening van de cliënt op.
        /// </summary>
        /// <param name="rekeningnummer">Het rekeningnummer van de op te zoeken rekening.</param>
        /// <returns>De rekening indien gevonden; null indien niet.</returns>
        public Rekening RekeningOpzoeken(string rekeningnummer)
        {
            Rekening gezochteRekening = null;
            foreach (Rekening rekening in rekeningen)
            {
                if (rekening.Rekeningnummer == rekeningnummer)
                    gezochteRekening = rekening;
            }
            return gezochteRekening;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBankConsole
{
    class Rekening
    {
        /// <summary>
        /// Het bankrekeningnummer in IBAN-formaat.
        /// </summary>
        public string Rekeningnummer
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Het bedrag dat op de rekening staat.
        /// </summary>
        public decimal Saldo
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Het bedrag dat je onder nul mag gaan.
        /// </summary>
        public decimal Kredietlimiet
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// De naam van de eigenaar van de rekening.
        /// </summary>
        public string Houder
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Een bedrag storten op de rekening.
        /// </summary>
        /// <param name="bedrag">Het bedrag dat op deze rekening gestort wordt.</param>
        /// <returns>Het nieuwe saldo van de rekening.</returns>
        public decimal Storten(decimal bedrag)
        {
            // Bedrag bij saldo tellen
            Saldo += bedrag;
            // het nieuwe saldo teruggeven
            return Saldo;
        }

        /// <summary>
        /// Een bedrag afhalen van de rekening.
        /// </summary>
        /// <param name="bedrag">Het bedrag dat we van deze rekening proberen afhalen.</param>
        /// <returns>True als de afhaling gelukt is; false indien niet.</returns>
        public bool Afhalen(decimal bedrag)
        {
            bool afhalenGeslaagd = false;

            // bedrag kan enkel van de rekening indien:
            // (saldo + kredietlimiet) >= bedrag
            if((Saldo + Kredietlimiet) >= bedrag)
            {
                Saldo -= bedrag;
                afhalenGeslaagd = true;
            }

            // Geef terug of afhaling geslaagd is of niet
            return afhalenGeslaagd;
        }
    }
}

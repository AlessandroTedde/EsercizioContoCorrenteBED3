using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Resolvers;

namespace EsercizioContoCorrenteBED3
{
    internal class ContoCorrente
    {
        public bool IsContoAperto { get; set; }
        public int Saldo  { get; set; }
        public uint Prel { get; set; }
        public uint Vers  { get; set; }
        
        
        
        public void Prelievo()
        {
            
            if (IsContoAperto == true && Prel < Saldo)
            {
               Console.WriteLine(Saldo - Prel);
            }
            if (IsContoAperto == false)
            {
               Console.WriteLine("Non hai ancora aperto un conto corrente.");
            }
            if (Prel > Saldo) 
            {
                Console.WriteLine("Non hai abbastanza liquidità per prelevare questa somma.");
            }
        }        
        public void Versamento()
        {
            if (IsContoAperto == true)
            {
               Console.WriteLine(Saldo + Vers);
            }
            if (IsContoAperto == false)
            {
               Console.WriteLine("Non hai ancora aperto un conto corrente.");
            }

        }
        public ContoCorrente(bool IsContoAperto, int Saldo, uint Prel, uint Vers)
        {
            this.Saldo = Saldo;
            this.Prel = Prel;
            this.Vers = Vers;
            this.IsContoAperto = IsContoAperto;
        }
    }
}

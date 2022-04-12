using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodotti_class
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private int iva;


        //costruttore
        public Prodotto(string nome, string descrizione, float prezzo, int iva)
        {
            //this si riferisce all'attuale uso del nome nella class
            this.codice = CreaCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        //getter sul serio / danno in return il parametro a cui si riferiscono con this.getXXXXX()
        // posso avere solo il getter, permettendo solo di leggere il dato!
        public string getNome()
        { return this.nome; }

        public string getDescrizione()
        { return this.descrizione; }

        public float getPrezzo()
        { return this.prezzo; }

        public int getCodice()
        { return this.codice; }

        //setter

        public void setNome(string nome)
        { 
            if (nome == null)
            {
                Console.WriteLine("Devi inserire un valore valido!");
            } else
            {
              this.nome = nome;
            }
        }






        //------------Metodi------------
        public void StampaNome()
        {
            Console.WriteLine("NOME PRODOTTO: " + this.getNome());
        }

        public void StampaNomeEsteso()
        {
            Console.WriteLine("NOME PRODOTTO ESTESO: " + this.getNome() + "-" + this.getCodice());
        }

        public void StampaCodice()
        {
            Console.WriteLine("CODICE - " + this.getCodice());
        }

        public void StampaDescrizione()
        {
            Console.WriteLine(" > " + this.getDescrizione());
        }

        public void StampaPrezzo()
        {
            Console.WriteLine(prezzoIvato() + "euro");
        }

        public void StampaProdotto()
        {
            Console.WriteLine("--------------------------------");
            //StampaNome();
            StampaNomeEsteso();
            //StampaCodice();
            StampaDescrizione();
            StampaPrezzo();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
        }

        //setter: metodi che permettono di inserire i dati senza che escano dai canoni scelti

        //-----------------------Hidden Math----------------------------------------

        public double prezzoIvato()
        {
            double totale = Math.Round(prezzo - (prezzo * iva / 100), 2);
            return totale;
        }

        //metodo creacodice casuale
        private int CreaCodice()
        {
            //inizializzo la classe con un costruttore di rng
            Random random = new Random();
            return random.Next(9999); //compreso tra
        }
    }

}

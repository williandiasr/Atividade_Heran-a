using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Carro : Veiculo
    {
        private string modelo;
        private int portas;
        private double porta_mala;


        public Carro()
        {
            
            this.Abastecimento = null;
            this.Marca = null;
            this.Placa = null;
            this.Chassi = 0;
            this.modelo = null;
            this.portas = 0;
            this.porta_mala = 0.0;
        }

        public Carro(string abastecimento, string marca, string placa, int chassi, string modelo, int portas, double porta_mala)
        {
           
            this.Abastecimento = abastecimento;
            this.Marca = marca;
            this.Placa = placa;
            this.Chassi = chassi;
            this.modelo = modelo;
            this.portas = portas;
            this.porta_mala = porta_mala;
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Portas
        {
            get { return portas; }
            set { portas = value; }
        }

        public double Porta_mala
        {
            get { return porta_mala; }
            set { porta_mala = value; }
        }

        public override String ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Abastecimento, " ", this.Marca, " ", this.Placa.ToString(), " ", this.Chassi.ToString(),"",this.modelo, " ", this.portas.ToString(), " ", this.porta_mala.ToString(), " ");
            return s;
        }
    }
}

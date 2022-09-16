using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Caminhao : Veiculo
    {
        private string cabine;
        private string tipocarga;
        private double pesocarga;
        private double altura;
        private int eixos;
        public Caminhao()
        {
            this.cabine = null;
            this.tipocarga = null;
            this.pesocarga = 0.0;
            this.altura = 0.0;
            this.eixos = 0;
            this.Abastecimento = null;
            this.Marca = null;
            this.Placa = null;
            this.Chassi = 0;
        }

        public Caminhao(string abastecimento, string marca, string placa, int chassi, string cabine, string tipocarga, double pesocarga, double altura, int eixos)
        {
            this.cabine = cabine;
            this.tipocarga = tipocarga;
            this.pesocarga = pesocarga;
            this.altura = altura;
            this.eixos = eixos;
            this.Abastecimento = abastecimento;
            this.Marca = marca;
            this.Placa = placa;
            this.Chassi = chassi;
        }

        public string Cabine
        {
            get { return cabine; }
            set { cabine = value; }
        }

        public string TipoCarga
        {
            get { return tipocarga; }
            set { tipocarga = value; }
        }
        public double PesoCarga
        {
            get { return pesocarga; }
            set { pesocarga = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public int Eixos
        {
            get { return eixos; }
            set { eixos = value; }
        }

        public override String ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Cabine, " ", this.TipoCarga, " ", this.PesoCarga.ToString(), " ", this.Altura.ToString(), " ", this.Eixos.ToString(), " ", this.Abastecimento, " ", this.Marca, " ", this.Placa.ToString(), " ", this.Chassi.ToString());
            return s;
        }
    }
}

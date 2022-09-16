using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public abstract class Veiculo
    {
        private string abastecimento;
        private string marca;
        private string placa;
        private int chassi;

        public Veiculo()
        {
            this.abastecimento = null;
            this.marca = null;
            this.placa = null;
            this.chassi = 0;
        }

        public Veiculo(string abastecimento, string marca, string placa, int chassi)
        {
            this.abastecimento = abastecimento;
            this.marca = marca;
            this.placa = placa;
            this.chassi = chassi;
        }

        public string Abastecimento
        {
            get { return abastecimento; }
            set { abastecimento = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public int Chassi
        {
            get { return chassi; }
            set { chassi = value; }
        }

        public abstract String ImprimeDados();
    }
}

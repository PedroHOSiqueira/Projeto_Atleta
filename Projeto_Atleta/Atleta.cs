using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;


        public string Nome
        {

            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo 'Nome' deve ser preenchido!");
                }
            }
            get { return this.nome; }
        }
        public double Altura
        {
            set
            {
                if (value > 0)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("O campo 'Altura' deve ter um valor maior que zero!");
                }
            }
            get { return this.altura; }
        }
        public double Peso
        {
            set
            {
                if (value > 0)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O campo 'Peso' deve ter um valor maior que zero!");
                }
            }
            get { return this.peso; }
        }
        public int Idade
        {
            set
            {
                if (value > 0)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("O campo 'Idade' deve ter um valor maior que zero!");
                }
            }
            get { return this.idade; }

        }
        

        public string ImprimrirDados()
        {
            return "Dados do Atleta " +
                   "\nNome: " + this.nome +
                   "\nIdade: " + this.idade +
                   "\nPeso: " + this.peso +
                   "\nAltura: " + this.altura;


        }

        public double CalcularIMC()
        {
            return
                this.peso / Math.Pow(this.altura, 2);
        }

    }
}

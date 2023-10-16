using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_World
{
    internal class DigiEscolhido : IDigiEscolhido
    {
        public DigiEscolhido()
        {
            int idade = 0;
            string nome = "";
            string brasao = "";
        }

        public int idade { get; private set; }

        public string nome { get; private set; }

        public string brasao { get; private set; }

        public void adicionarNome(string nome)
        {
            this.nome = nome;
        }
        public string adicionarIdade(int idade)
        {
            try
            {
                if (idade > 0)
                {
                    this.idade = idade;
                    return "\n";
                }
                else
                    throw new ArgumentException("Idade insérida não é valída.");
            }
            catch (ArgumentException ex)
            {
                return  ex.Message;
            }
        }

        string[] listaBrasoes = new string[] { "coragem", "amizade", "esperança", "luz", "amor", "sinceridade", "sabedoria", "confiança" };

        public string[] brasoesDisponiveis()
        {
            return listaBrasoes;
        }
        public string adicionarBrasao(string brasao)
        {
            try {

                if (!listaBrasoes.Contains(brasao))
                {

                    throw new ArgumentException("\nBrasão Escolhido inválido");
                }

                else
                    this.brasao = brasao;
                return  $"\nO brasão {brasao} foi escolhido";

                }
            catch (ArgumentException ex) 
            {
                return ex.Message;
            }
        }

    }
}

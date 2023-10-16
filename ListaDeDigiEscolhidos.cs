using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_World
{
    internal class ListaDeDigiEscolhidos
    {
        public ListaDeDigiEscolhidos() 
        {
            this.listaDeDigiEscolhido = new List<DigiEscolhido>();
        }
        private List<DigiEscolhido> listaDeDigiEscolhido;
        public string adicionarDigiEscolhido(DigiEscolhido protagonista)
        {
            try
            {
                if (protagonista.brasao != null && protagonista.idade > 0)
                {
                    this.listaDeDigiEscolhido.Add(protagonista);
                    return $"\nCadastro concluido com sucesso!";
                }
                else
                    throw new Exception("\nNecessário informar um Brasão para se cadastrar junto a uma idade válida");
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }
        public List<string> listarDigiEscolhidos()
        {
            List<string> dadosDaConta = new List<string>();

            foreach (DigiEscolhido item in listaDeDigiEscolhido)
            {
                dadosDaConta.Add(" === Dados da Conta  === " +
                $"\nNome do Digiescolhido é: {item.nome}" +
                $"\nA idade do Digiescolhido é: {item.idade} " +
                $"\nNome do Digiescolhido é: {item.brasao}");
            }
            if (dadosDaConta.Count > 0)
                return dadosDaConta;

            else
                dadosDaConta.Add("\nNão há DigiEscolhidos registrados!");
            return dadosDaConta;
        }
        public string removerDigiEscolhido(string nomeDeletado)
        {

            foreach (DigiEscolhido item in listaDeDigiEscolhido)
            {
                if (nomeDeletado == item.nome)
                {
                    listaDeDigiEscolhido.Remove(item);
                    return "\nDigiEscolhido deletado com sucesso!";
                }
            }
            return "Não há DigiEscolhidos registrados!";

        }
    }
}

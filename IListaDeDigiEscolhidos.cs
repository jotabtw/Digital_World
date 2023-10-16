using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_World
{
    internal interface IListaDeDigiEscolhidos
    {
        void adicionarDigiEscolhido(DigiEscolhido digiescolhido);
        List<string> listarDigiEscolhidos();
        string removerDigiEscolhido(string nomeDeletado);
    }
}

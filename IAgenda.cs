using System.Collections.Generic;

namespace Aula31_whatsapp
{
    public interface IAgenda
    {
         void Cadastrar(Contato contato);
         void Excluir(string contato);
         List<Contato> Ler();

    }
}
using System;
using System.Collections.Generic;

namespace Aula31_whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
         Agenda Agenda = new Agenda();
            Contato c1 = new Contato("Lucas" , "970707077");
            Contato c2 = new Contato("João" , "924462469");
             Contato c3 = new Contato("carlos" , "924465767");
              Contato c4 = new Contato("eduardo" , "924465669");
            

           
            List<Contato> Lista = Agenda.Ler();
            System.Console.WriteLine("Lista de Contatos");
            foreach(Contato contatos in Lista){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{contatos.Nome} -- {contatos.Telefone}");
                Console.ResetColor();
            }
             
        }
    }
}

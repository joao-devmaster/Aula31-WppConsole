namespace Aula31_whatsapp
{
    public class Contato 
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(string _Nome, string _Telefone)
        {
            this.Nome = _Nome;
            this.Telefone = _Telefone;


        }
    }
}
namespace Aula08Abstracao

{
    public class Boleto: Pagamento 

  {
        public Datetime dataVencimento { get;set;}

        public string bancoEmissor {get;set;}

        public string codDeBarras {get;set;}


        public string Registrar (){
          return "Boleto registrado com sucesso!";

        }

    }
}
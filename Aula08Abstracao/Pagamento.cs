namespace Aula08Abstracao

   {
    public class Pagamento
{

public data {get; set;}

public float valor {get; set;}

public string Pagar(float valorPago){
   return "Valor pago: R$"+valorPago;

}

  public string Cancelar(){
            return "Pagamento cancelado";
        }

    }
}




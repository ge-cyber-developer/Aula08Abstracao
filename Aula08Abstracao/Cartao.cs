namespace Aula08Abstracao
{

public class Cartao : Pagamento 

{
    public string titular {get;set;}
    
    public int numero {get;set;}

    public string cvv {get;set;}

    public string bandeira {get; set;}


             public bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

    }
}




/* ENUMERACOES
 - E um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas;
 - Palavra chave em C#: ENUM
 - Nota: ENUM e um tipo valor;
 - Vantagem: melhor semantica, codigo mais legivel e auxiliado pelo compilador;
 - Referencia: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum;

 Exemplo:
 - Ciclo de vida de um pedido (UML - Diagrama de Maquina de Estados):
	> Entrada do pedido --> PendingPayment --billing-> Processing --dispatch-> Shipped --deliver-> Delivered --> Fim;

	-----------------------------

	enum OrderStatus : int // Cada valor da enumeracao e um valor inteiro
	{
	PendingPayment = 0, // Valores possiveis para o status do pedido
	Processing = 1,
	Shipped = 2,
	Delivered = 3
	}	

	-----------------------------

	class Order
	{
	public int Id { get; set; } // Codigo do pedido
	public DateTime Moment { get; set; } // Instante em que o pedido ocorreu
	public OrderStatus Status { get; set; } // Status do pedido - OrderStatus e tipo ENUM
	}

	-----------------------------

AVISO IMPORTANTE SOBRE CONVERSAO DE STRING

 No proximo video vamos aprender sobre ENUMERAÇOES.

 Na aula fazemos a conversao de string para enumeração assim:

 OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
 Mas, dependendo da versao do compilador C#, isso pode dar problema. Se for o caso, por favor tente deste jeito:

 OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
 Se mesmo assim ainda tiver dando erro, ha ainda uma terceira forma:

 OrderStatus os;
 Enum.TryParse("Delivered", out os);

 Notacao UML (visualizacao mais clara):
 - Esteriotipo: <<enum>> - "enum" e uma informacao adicional customizavel. No caso, foi colocado para indicar que 
   o tipo e uma enumeracao;
 - Nome da clase: OrderStatus;
 - Constantes:
	> - PENDING_PAYMENT : int = 0
	> - PROCESSING : int = 1
	> - SHIPPED : int = 2
	> - DELIVERED : int = 3

 Outra forma de Notacao UML (forma mais detalhada, porem, de visualizacao menos clara):
 - Esteriotipo: <<enum>> - "enum" e uma informacao adicional customizavel. No caso, foi colocado para indicar que 
   o tipo e uma enumeracao;
 - Nome da clase: OrderStatus;
 - Constantes:
	> - <<enum constant>> PENDING_PAYMENT : int = 0
	> - <<enum constant>> PROCESSING : int = 1
	> - <<enum constant>> SHIPPED : int = 2
	> - <<enum constant>> DELIVERED : int = 3

CODIGO PARA A AULA: https://github.com/acenelio/enum1-csharp

*/

using System;
using Aula115_Enumeracoes.Entities; // Necessario para se utilizar outros NAMESPACEs
using Aula115_Enumeracoes.Entities.Enums;

namespace Aula115_Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            Console.WriteLine();

            //Conversao de Enum para String
            string txt = OrderStatus.PendingPayment.ToString();

            // Conversao de String para Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); /* O nome entre parenteses deve ser igual ao da 
			                                                        * classe OrderStatus */

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
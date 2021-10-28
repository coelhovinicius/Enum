/* Classe ENUM */

namespace Aula115_Enumeracoes.Entities.Enums
{
    //Definicao do tipo ENUM "OderStatus"
    enum OrderStatus : int // Alterar "class" para "enum" e incluir o " : int" para identificar que serao numeros inteiros
    {
        PendingPayment = 0, // Valores possiveis para o status do pedido - Nao e necessario atribuir valores
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
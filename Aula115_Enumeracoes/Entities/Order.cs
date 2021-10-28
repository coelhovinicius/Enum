using System;
using Aula115_Enumeracoes.Entities.Enums; // Necessario para se utilizar outros NAMESPACEs

namespace Aula115_Enumeracoes.Entities
{
    class Order
    {
        public int Id { get; set; } // Numero de identificacao do pedido
        public DateTime Moment { get; set; } // Momento em que o pedido foi efetuado
        public OrderStatus Status { get; set; } // Status do pedido

        public override string ToString() // Override para retornar as informacoes do pedido
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}

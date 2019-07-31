using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class UserDetail
    {
        /// <summary>
        /// Campo Identificador
        /// </summary>
        public int UserDetailId { get; set; }

        /// <summary>
        /// Nome Rua correspondete a entrega.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Pode ser o número da casa ou apartamento
        /// </summary>
        public string HouseNumber { get; set; }

        /// <summary>
        /// Equivalente ao CEP
        /// </summary>
        public int CodeArea { get; set; }

        /// <summary>
        /// Estado de entrega
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// UF Estado de Entrega
        /// </summary>
        public string UF { get; set; }

        /// <summary>
        /// Número de Telefone.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Refencia o usuário que está a comprar. 
        /// </summary>
        public int UserId { get; set; }


    }
}

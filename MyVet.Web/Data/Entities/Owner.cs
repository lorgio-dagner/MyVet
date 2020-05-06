using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        /* Aqui un ejemplo de como mostrar las validaciones de campos
        ***********
        // {0} se refiere al campo en este caso a Document y {1} al valor de MaxLength
        [MaxLength(30, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }
        ***********
        */


        public int Id { get; set; }

        // Aqui creo la relacion (1:1) entre Owner y User y con esto puedo acceder a los campos de User
        public User User { get; set; }

        // Aqui creo la relacion Owner - Pet (1:N)
        public ICollection<Pet> Pets { get; set; }

        //Aqui creo la relacion Owner - Agenda (1:N)
        public ICollection<Agenda> Agendas { get; set; }

    }
}

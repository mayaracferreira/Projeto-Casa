using System;

namespace CasaShow.Models
{
    public class Show
    
    {


        public int Id {get;set;}

        public string Nome {get;set;}

        public float Valor {get;set;}

        public DateTime Hora {get;set;}

        public int Aux {get;set;}

        public string Categoria {get;set;}

        public Casa CasaseClubes {get;set;}

 

        
    }
}
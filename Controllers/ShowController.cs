using System;
using Microsoft.AspNetCore.Mvc;
using CasaShow.Controllers;
using CasaShow.Data;
using CasaShow.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CasaShow.Controllers
{
   namespace CasaShow.Controllers
{
    public class ShowController : Controller 
    {

     private readonly ApplicationsDbContext database;

        public ShowController (ApplicationsDbContext database) {
                this.database = database;
    
        }
       public IActionResult Cadastrar (){
           ViewBag.CasaseClubes = database.Casas.ToList();
           return View ();

       } 

       public IActionResult Editar (int Id){
           
       return RedirectToAction ("Cadastrar");
        
       }

       
       public IActionResult Deletar (int ID){
            Show aux = database.Shows.First (aux => aux.Id == ID);
          database.Shows.Remove(aux);
          database.SaveChanges();
           return RedirectToAction ("Proximos"); 
       }



        [HttpPost]
       public IActionResult Salvar (Show show){
             if (ModelState.IsValid){
               Show Show = new Show ();
               Show.Nome = show.Nome;
               Show.Valor = show.Valor;
               Show.Hora = show.Hora;
               Show.Categoria = show.Categoria;

               Show.CasaseClubes = database.Casas.First(c => c.Id == show.Aux);
               database.Shows.Add(Show);
               database.SaveChanges();
               return RedirectToAction ("Proximos");
           }

           else {
            
               ViewBag.CasaseClubes = database.Casas.ToList();

                return RedirectToAction ("Proximos");
           }
      
       }
       
        public IActionResult CasaseClubes (){
          var casas = database.Casas.ToList ();
          return View (casas);  
        }
        public IActionResult Proximos()  {

            
            var proximos = database.Shows.Include (p => p.CasaseClubes).ToList ();
            return View(proximos);
         
        }

        public IActionResult Ingressos()  {

            
            var ingressos = database.Shows.Include (p => p.CasaseClubes).ToList ();
            return View(ingressos);
        }
           
           
           public IActionResult Comprar (int Id){
            ViewBag.T = database.Shows.First(i => i.Id == Id);
            return View ();
           
       }

            public IActionResult SalvarIngresso (Ingresso ingressotemp){

               if (ModelState.IsValid){

            Ingresso ingresso = new Ingresso ();

            ingresso.Show = database.Shows.First (i => i.Id == ingressotemp.Aux);
            database.Ingressos.Add (ingresso);
            database.SaveChanges();
            return View ();
           }


               return RedirectToAction ("Proximos");


        
            }
            
           
           
    
    }
}

}
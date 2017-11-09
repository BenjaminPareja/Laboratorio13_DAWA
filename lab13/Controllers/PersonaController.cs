using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab13.Models;

namespace lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "juan",
                Apellido = "perez",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "mario",
                Apellido = "salluca",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "benjamin",
                Apellido = "pareja",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 4,
                Nombre = "jaime",
                Apellido = "bravo",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            return View(personas);
        }
        public ActionResult Mostrar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "juan",
                Apellido = "perez",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "mario",
                Apellido = "salluca",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "benjamin",
                Apellido = "pareja",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 4,
                Nombre = "jaime",
                Apellido = "bravo",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            Persona persona = (from p in personas
                               where p.PersonaID == id
                               select p).FirstOrDefault();
            return View(persona);
        }
        public ActionResult Buscar(string Texto)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "juan",
                Apellido = "perez",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "mario",
                Apellido = "salluca",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "benjamin",
                Apellido = "pareja",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 4,
                Nombre = "jaime",
                Apellido = "bravo",
                Direccion = "Av. Evergreen 1234",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });
            //Console.WriteLine(texto);
            Persona persona = (from p in personas
                               where p.Nombre.Contains(Texto) ||  p.Apellido.Contains(Texto)
                               select p).FirstOrDefault();
            return View(persona);
        }
    }
}
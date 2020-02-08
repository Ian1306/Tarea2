using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tarea2.Controllers
{
    public class PeriodicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Periodica()
        {
            String[] array = new string[120];
            array[1] = "H Hidrogeno";
            array[2] = "Li Litio";
            array[3] = "Be Berilio";
            array[4] = "Na Sodio";
            array[5] = "Mg Magnecio";
            array[6] = "K Potasio";
            array[7] = "Ca Calcio";
            array[8] = "Rb Rubidio";
            array[9] = "Sr Estroncio";
            array[10] = "Cs Cesio";
            array[11] = "Ba Barlo";
            array[12] = "Fr Francio";
            array[13] = "Ra Radlo";
            array[14] = "Sc Escandio";
            array[15] = "Y Itrio";
            array[16] = "La-Lu Lantanidos";
            array[17] = "Ac-Lr Actinidos";
            array[18] = "Ti Titanio";
            array[19] = "Zr Circonio";
            array[20] = "Hf Hafnio";
            array[21] = "Rf Rutherfordlo";
            array[22] = "V Vanadio";

            ViewBag.ArrayTabla = array;

            return View();
            

        }

        public IActionResult TablaGeneral()
        {
            return View();

        }

        }
}
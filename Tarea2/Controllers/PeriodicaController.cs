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
            array[23] = "Nb Niobio";
            array[24] = "Ta Tantalo";
            array[25] = "Db Dubnio";
            array[26] = "Cr Cromo";
            array[27] = "Mo Molibdeno";
            array[28] = "W Wolframio";
            array[29] = "Sg Seaborgio";
            array[30] = "Mn Manganeso";
            array[31] = "Tc Tecnecio";
            array[32] = "Re Renio";
            array[33] = "Bh Bohrio";
            array[34] = "Fe Hierro";
            array[35] = "Ru Rutenio";
            array[36] = "Os Osmio";
            array[37] = "Hs Hasio";
            array[38] = "Co Cobalto";
            array[39] = "Rh Rodio";
            array[40] = "Ir Iridio";
            array[41] = "Mt Meitnerio";
            array[42] = "Ni Niquel";
            array[43] = "Pd Paladio";
            array[44] = "Pt Platino";
            array[45] = "Ds DarmsTatio";
            array[46] = "Cu Cobre";
            array[47] = "Ag Plata";
            array[48] = "Au Oro";
            array[49] = "Rg Roentgenio";
            array[50] = "Zn Zinc";
            array[51] = "Cd Cadmio";
            array[52] = "Hg Mercurio";
            array[53] = "Cn Copenicio";
            array[54] = "Ga Galio";
            array[55] = "In Indio";
            array[56] = "Ti Talio";
            array[57] = "Nh Nihinio";
            array[58] = "Ge Germanio";
            array[59] = "Sn Estano";
            array[60] = "Pb Plomo";
            array[61] = "Fi Flerovio";
            array[62] = "As Arsenico";
            array[63] = "Sb Antimonio";
            array[64] = "Bi Bismuto";
            array[65] = "Mc Moscovio";
            array[66] = "Se Selenio";
            array[67] = "Te Telurio";
            array[68] = "Po Polonio";
            array[69] = "Lv Livermorio";
            array[70] = "Br Bromo";
            array[71] = "I Yodo";
            array[72] = "At Astato";
            array[73] = "Ts Teneso";
            array[74] = "Kr Kripton";
            array[75] = "Xe Xenon";
            array[76] = "Rn Radon";
            array[77] = "Og Oganeson";
            array[78] = "He helio";
            array[79] = "B Boro";
            array[80] = "Al Aluminio";
            array[81] = "C Carbono";
            array[82] = "Si Silicio";
            array[83] = "N Nitrogeno";
            array[84] = "P Fosforo";
            array[85] = "O Oxigeno";
            array[86] = "S Azufre";
            array[87] = "F Fluor";
            array[88] = "Cl Cloro";
            array[89] = "Ne Neon";
            array[90] = "Ar Argon";

            ViewBag.ArrayTabla = array;

            return View();
            

        }

        public IActionResult TablaGeneral()
        {
            return View();

        }

        }
}
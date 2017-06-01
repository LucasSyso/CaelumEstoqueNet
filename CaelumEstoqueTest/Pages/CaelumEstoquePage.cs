using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaelumEstoqueTest.Pages
{
    /* CaelumEstoquePage class
     * 
     * Encapsula comportamentos e atributos comuns a todas
     * as páginas do sistema, implementando assim o design
     * pattern PageObject.
     */
    public class CaelumEstoquePage
    {
        public static string UrlBase { get; private set; } = 
            "http://localhost:51270";
    }
}

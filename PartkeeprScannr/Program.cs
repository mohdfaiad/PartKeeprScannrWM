using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PartkeeprScannr
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new PartShow());
            
        }
    }
}
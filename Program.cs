using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto01
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;


            try
            {

                n = txt.Text.Replace(",","").Replace(".","");
                if (n.Equals(""))
                
                    n = " ";
                    n = n.PadLeft(3,'0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1,n.Length-1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("0:N",v);
                txt.SelectionStart = txt.Text.Length;  

            }
            catch (Exception)
            {

                
            }
        
        
        }



    }
}

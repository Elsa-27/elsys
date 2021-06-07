using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks; 

namespace login
{
     class Program
    {
       
       
        static void Main(string[] args)
        {
            using (Models.bdloginEntities1 db =new Models.bdloginEntities1())

            {
                string usuario = "admin";
                string pass = "admin1234";

                string epass = Encrypt.GetSHA256(pass);

                var oUser = (from d in db.usuariose
                             where d.usuario == usuario && d.pass == epass
                             select d).FirstOrDefault();
                if (oUser != null)
                    Console.WriteLine("Existe");
                else
                    Console.WriteLine("Datos Invalidos");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        }
    }
}

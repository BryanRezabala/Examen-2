using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{

    public class Singleton
    {
        private static Singleton instance = null;
        public string mensaje = "";

        protected Singleton()
        {
            mensaje = "Lista de menu de comida en la costa";

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrupal.clases
{
    public class Nota
    {
        static Nota() { }
        private String nombre;
        
        private int ban = 0;
        private String[] numeropalabras;
        public String Nombre
        {
            get { return nombre; }
            set {
                do
                {
                    numeropalabras = value.Split(' ');
                    if (numeropalabras.Length==4)
                    {
                        ban = 1;
                    }
                    else
                    {
                        Console.WriteLine("Error al verificar el nombre, ingrese el nombre completo");
                        value = Console.ReadLine();
                    }
                } while (ban==0);
                
                nombre = value; }
        }


        private float ac1p;

        public float Ac1P
        {
            get
            {
                return ((ac1p * 25) / 100);
            }
            set
            {
                if (ac1p < 0 || ac1p > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                ac1p = value;
            }
        }
        private float pr1p;

        public float Pr1P
        {
            get
            {
                return ((pr1p * 25) / 100);
            }
            set
            {
                if (pr1p < 0 || pr1p > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                pr1p = value;
            }
        }

        private float ta1p;

        public float Ta1P
        {
            get { return ((ta1p * 20) / 100); }
            set
            {
                if (ta1p < 0 || ta1p > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                ta1p = value;
            }
        }
        private float ef1p;

        public float Ef1P
        {
            get { return ((ef1p * 30) / 100); }
            set
            {
                if (ef1p < 0 || ef1p > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                ef1p = value;
            }
        }
        public float PrimerParcial
        {
            get { return (Ac1P + Ta1P + Ef1P + Pr1P); }
        }
        private float ac2p;
        public float Ac2P
        {
            get { return ((ac2p * 25) / 100); }
            set
            {
                if (ac2p < 0 || ac2p > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                ac2p = value;
            }
        }
        private float pr2p;

        public float Pr2P
        {
            get { return ((pr2p * 25) / 100); }
            set
            {
                if (pr2p < 0 || pr2p > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                pr2p = value;
            }
        }
        private float ta2p;

        public float Ta2P
        {
            get { return ((ta2p * 20) / 100); }
            set
            {
                if (ta2p < 0 || ta2p > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                ta2p = value;
            }
        }
        private float ef2p;

        public float Ef2P
        {
            get { return ((ef2p * 30) / 100); }
            set
            {
                if (ef2p < 0 || ef2p > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                ef2p = value;
            }
        }
        public float SegundoParcial
        {
            get { return (Ac2P + Ta2P + Ef2P + Pr2P); }
        }
        public float Suma
        {
            get { return ((PrimerParcial + SegundoParcial)); }
        }
        private float recuperacion;

        public float Recuperacion
        {
            get { return recuperacion; }
            set {
                if (recuperacion < 0 || recuperacion > 10)
                {
                    throw new Exception("El numero que ingreso no esta en el rango permitido");
                }
                recuperacion = value; }
        }
        public float Suma2
        {
            get { return (((Suma / 2) + Recuperacion)); }
        }

        public float Final
        {
            get
            {
                if (Suma >= 14)
                {
                    return (Suma / 2);
                }
                else
                {
                    return (Suma2 / 2);
                }
            }

        }
        public String Estado
        {


            get
            {
                if (Final >= 7)
                {
                    return "APROBADO";
                }
                else
                {

                    return "REPROBADO";
                }


            }


        }



    }
}

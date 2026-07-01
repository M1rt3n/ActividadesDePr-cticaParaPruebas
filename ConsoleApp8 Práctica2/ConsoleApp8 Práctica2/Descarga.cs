using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Práctica2
{
    public class Descarga
    {
        private int _tamañomegas;
        public int TamañoMegas
        {
            get { return _tamañomegas; }
            set { _tamañomegas = value; }
        }
        private int _progreso;
        public int Progreso
        {
            get { return _progreso; }
            set { _progreso = value; }
        }

        public Descarga(int tamañomegas, int progreso)
        {
            TamañoMegas = tamañomegas;
            Progreso = progreso;
        }

        public virtual string ActualizarProgreso(int MegasDescargadas)
        {
            Progreso += (MegasDescargadas/TamañoMegas)*100;
            if (Progreso > 100)
            {
                Progreso = 100;
            }
            else
            {
                if (Progreso < 0)
                {
                    Progreso = 0;
                }
            }
            if (Progreso == 100)
            {
                return $"Descarga completada";
            }
            else
            {
                return $"Descarga en proceso: {Progreso}% de la descarga completada";
            }
        }
    }

    public class StreamingVideo : Descarga
    {
        private int _buffermínimo;
        public int BufferMínimo
        {
            get { return _buffermínimo; }
            set { _buffermínimo = value; }
        }
        public StreamingVideo(int tamañomegas, int progreso, int buffermínimo) : base(tamañomegas, progreso)
        {
            BufferMínimo = buffermínimo;
        }
        public override string ActualizarProgreso(int MegasDescargadas)
        {
            Progreso += (int)((double)MegasDescargadas / TamañoMegas * 100);
            if (Progreso > 100)
            {
                Progreso = 100;
            }
            else
            {
                if (Progreso < 0)
                {
                    Progreso = 0;
                }
            }
            if (Progreso < BufferMínimo)
            {
                return $"Cargando... Video pausado";
            }
            else
            {
                if (Progreso == 100)
                {
                    return $"Descarga completada";
                }
                else
                {
                    return $"Descarga en proceso: {Progreso}% de la descarga completada";
                }
            }
        }
    }
    public class ArchivoComprimido : Descarga
    {
        private bool _esseguro;
        public bool EsSeguro
        {
            get { return _esseguro; }
            set { _esseguro = value; }
        }
        public ArchivoComprimido(int tamañomegas, int progreso, bool esseguro) : base(tamañomegas, progreso)
        {
            EsSeguro = esseguro;
        }
        public override string ActualizarProgreso(int MegasDescargadas)
        {
            Progreso += (int)((double)MegasDescargadas / TamañoMegas * 100);
            if (Progreso > 100)
            {
                Progreso = 100;
            }
            else
            {
                if (Progreso < 0)
                {
                    Progreso = 0;
                }
            }
            if (Progreso == 100 && !EsSeguro)
            {
                return $"Descarga abortada por amenaza detectada";
            }
            if (Progreso == 100)
            {
                return $"Descarga completada";
            }
            else
            {
                return $"Descarga en proceso: {Progreso}% de la descarga completada";
            }
        }
    }
}

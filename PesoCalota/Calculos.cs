using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PesoCalota
{
    class Calculos
    {
        Calota calota = new Calota();

        /// <summary>
        /// Este método recebe os valores das dimensões da calota e distribui para as
        /// demais funções calcularem
        /// </summary>
        /// <param name="diametroExterno"></param>
        /// <param name="diametroFuro"></param>
        /// <param name="espessura"></param>
        /// <param name="raioEsferico"></param>
        /// <returns></returns>
        public static double Calculo(double diametroExterno, double diametroFuro,
                                      double espessura, double raioEsferico)
        {
            return VolumeParteReta(diametroExterno, diametroFuro, espessura);
        }
    }
}

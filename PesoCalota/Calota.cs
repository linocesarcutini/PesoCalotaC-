using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoCalota
{
    public class Calota
    {
        private double DiametroExterno { get; set; }
        private double DiametroFuro { get; set; }
        private double RaioEsferico { get; set; }
        private double Espessura { get; set; }
        public double PesoTotal { get; set; }

        /// <summary>
        /// Calcula a altura do arco
        /// </summary>
        /// <param name="raioEsferico"></param>
        /// <param name="diametro"></param>
        private double AlturaDoArco(double diametro)
        {
            return this.RaioEsferico - (Math.Sqrt(Math.Pow(this.RaioEsferico, 2) - 
                                  Math.Pow((diametro / 2), 2)));
        }

        /// <summary>
        /// Calcula o volume da parte reta abaixo do raio esférico
        /// </summary>
        /// <param name="diametro"></param>
        private double VolumeParteRetaFuroRetirado()
        {
            double volumeTotalCilindro = 2 * Math.PI * this.DiametroExterno * this.Espessura;
            double volumeFuro = 2 * Math.PI * this.DiametroFuro * this.Espessura;
            double alturaDoArco = AlturaDoArco(this.DiametroExterno);

            return ((Math.PI * (Math.Pow(diametro, 2))) / 4) * espessura - 
                   ((Math.PI * (Math.Pow(diametro, 2))) / 4) * espessura;
        }

        /// <summary>
        /// Calcula o volume da parte esférica
        /// </summary>
        /// <param name="diametro"></param>
        private double VolumeEsferico(double diametro)
        {
            double alturaRaio = AlturaDoArco(this.RaioEsferico, diametro);

            double volumeEsferico = (Math.PI * Math.Pow(alturaRaio, 2) *
                                    (3 * this.RaioEsferico - alturaRaio)) / 3;

            return volumeEsferico;
        }

        private double VolumeTotal()
        {
            double volumeTotalCilindro = 2 * Math.PI * this.DiametroExterno * this.Espessura;
            double volumeFuro = 2 * Math.PI * this.DiametroFuro * this.Espessura;
            double volumeReto = VolumeParteReta(this.DiametroExterno, this.Espessura);
        }
    }
}

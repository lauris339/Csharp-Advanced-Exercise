using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siuntos
{
        public class Siunta
    {
        public readonly List<Preke> PrekiuSarasas;
        public string Siuntejas { get; }
        public string Gavejas { get; set; }
        public string SiuntosDydis { get; private set; }
        const double SsiuntosSvoris = 0.5;
        const double MsiuntosSvoris = 2;
        const double LsiuntosSvoris = 5;
        public double Kaina { get; set; }
        public DateTime SiuntimoData { get; private set; }
        ISiuntosTaisykles siuntosTaisykle;

        public Siunta(string siuntejas, ISiuntosTaisykles taisykle)
        {
            Siuntejas = siuntejas;
            PrekiuSarasas = new List<Preke>();
            SiuntimoData = new DateTime();
            siuntosTaisykle = taisykle;
        }

        public void SiuntosDydzioSkaiciuokle()
        {
            double svoris = 0;
            ///S - iki 0.5kg
            ///M - iki 2kg
            ///L - iki 5kg
            ///XL 5kg<
            ///
            foreach (var item in PrekiuSarasas)
            {
                svoris += item.Svoris;
            }
            if (svoris <= SsiuntosSvoris)
            {
                SiuntosDydis = "S";
            }
            else if (svoris <= MsiuntosSvoris)
            {
                SiuntosDydis = "M";
            }
            else if (svoris <= LsiuntosSvoris)
            {
                SiuntosDydis = "L";
            }
            else if(svoris <= 50)
            {
                SiuntosDydis = "XL";
            }
            else
            {
                throw new NotImplementedException();
            }
            siuntosTaisykle.SiuntosKainosSkaiciuokle(this);
        }


    }
}

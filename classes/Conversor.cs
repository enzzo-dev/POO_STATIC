using System;

namespace POO_STATIC.classes
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5;

        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal(float valorDol){
            return valorDol * cotacaoDolar;
        }


    }
}
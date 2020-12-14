using System;

namespace POO_STATIC.classes
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.31f;

        private static float cotacaoEuro = 6.22f;

        public static float RealParaDolar(float valorRS){
            return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal(float valorDol){
            return valorDol * cotacaoDolar;
        }

        public static float EuroParaReal( float valorEuro){
            return valorEuro / cotacaoEuro;
        }

        public static float RealParaEuro(float ValorReal){
            return ValorReal * cotacaoEuro;
        }


    }
}
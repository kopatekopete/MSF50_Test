using System;

namespace Kenwin.PPP.Negocio.Comun
{
    public static class UtilidadesDecimal
    {
        public static string ConvertirAString(this Decimal valor)
        {
            return ConvertirAString(valor, Formatos.FormatoDecimal);
        }

        public static string ConvertirAString(this Decimal valor, string formato)
        {
            return valor.ToString(formato);
        }

        public static string ConvertirAString(this Decimal? valor)
        {
            return ConvertirAString(valor, Formatos.FormatoDecimal);
        }

        public static string ConvertirAString(this Decimal? valor, string formato)
        {
            if (!valor.HasValue)
            {
                return null;
            }
            return valor.Value.ToString(formato);
        }

        public static decimal? ConvertirADecimal(this string numeroDecimal)
        {
            bool esPorcentaje = false;

            if (!String.IsNullOrWhiteSpace(numeroDecimal))
            {
                if (numeroDecimal.IndexOf('%') > 0)
                {
                    esPorcentaje = true;
                    numeroDecimal = numeroDecimal.Replace("%", String.Empty);
                }

                Decimal valor;
                if (Decimal.TryParse(numeroDecimal, out  valor))
                {
                    if (esPorcentaje)
                    {
                        valor = valor / 100;
                    }
                    return valor;
                }

            }
            return null;
        }

        public static Decimal ConvertirADecimal(this string numeroDecimal, Decimal valorDefault)
        {
            var resultado = ConvertirADecimal(numeroDecimal);
            if(!resultado.HasValue)
            {
                return valorDefault;
            }
            return resultado.Value;
        }
    }
}

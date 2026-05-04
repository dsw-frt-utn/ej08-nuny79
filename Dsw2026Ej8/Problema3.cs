using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            // copia del entero
            int copia = originalValue;
            copia++;

            // copia de la referencia
            Product productoCopia = product;
            productoCopia.UpdateDescription("Descripcion modificada");

            return $"{originalValue}-{copia}-{product.GetDescription()}";
        }
    }
}

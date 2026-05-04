using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        protected decimal _amount;

        public Sale(decimal amount)
        {
            _amount = amount;
        }

        public virtual decimal CalculateTotal()
        {
            return _amount;
        }
    }

    public class RetailSale : Sale
    {
        public RetailSale(decimal amount) : base(amount) { }

        public override decimal CalculateTotal()
        {
            return _amount;
        }
    }

    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount) : base(amount) { }

        public override decimal CalculateTotal()
        {
            return _amount * 0.90m;
        }
    }

    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }

}

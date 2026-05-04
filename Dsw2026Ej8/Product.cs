
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        private string _description;

        public Product(string description)
        {
            _description = description;
        }

        public string GetDescription() => _description;

        public void UpdateDescription(string description)
        {
            _description = description;
        }
    }
}

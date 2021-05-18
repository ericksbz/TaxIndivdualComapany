using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExPessoaFisica.Entities
{
    class Company : TaxPayer
    {

        public int NumberOfEmployess { get; set; }

        public Company(string name)
        {
        }

        public Company(int numberOfEmployess, string name, double anualIncomes) : base (name,  anualIncomes)
        {
            NumberOfEmployess = numberOfEmployess;
        }

        public override double Tax()
        {
           if (NumberOfEmployess > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }

    }
}

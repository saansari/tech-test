using AnyCompany.Interfaces;

namespace AnyCompany
{
	public class VATProvider : IVATProvider
    {
        public double GetVAT(string country)
        {
            if (country == "UK")
                return 0.2d;
            else
                return 0;
        }
    }
}

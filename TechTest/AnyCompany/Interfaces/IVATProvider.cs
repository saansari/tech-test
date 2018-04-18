using AnyCompany;

namespace AnyCompany.Interfaces
{
	public interface IVATProvider
	{
		double GetVAT(string country);
	}
}


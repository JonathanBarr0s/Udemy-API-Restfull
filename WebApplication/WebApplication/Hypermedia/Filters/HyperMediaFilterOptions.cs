using WebApplication.Hypermedia.Abstract;

namespace WebApplication.Hypermedia.Filters
{
	public class HyperMediaFilterOptions
	{
		public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
	}
}

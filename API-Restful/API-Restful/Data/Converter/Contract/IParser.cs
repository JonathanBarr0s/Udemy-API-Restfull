namespace API_Restful.Data.Converter.Contract
{
	public interface IParser<Origin, Destination>
	{
		Destination Parse(Origin origin);
		List<Destination> ParseList(List<Origin> origin);
	}
}

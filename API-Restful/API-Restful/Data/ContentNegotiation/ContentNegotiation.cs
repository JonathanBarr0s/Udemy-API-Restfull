using Microsoft.Net.Http.Headers;

namespace API_Restful.Data.ContentNegotiation
{
	public static class ContentNegotiation
	{
		public static IMvcBuilder AddContentNegotiation(this IMvcBuilder builder)
		{
			return builder.AddMvcOptions(options =>
			{
				options.RespectBrowserAcceptHeader = true;
				options.ReturnHttpNotAcceptable = true;

				options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("application/xml"));
				options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
			}).AddXmlSerializerFormatters();
		}
	}
}
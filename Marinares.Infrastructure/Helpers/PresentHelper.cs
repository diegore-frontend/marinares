using System.Collections.Generic;
using System.IO;
using Marinares.Data.Shared;
using Newtonsoft.Json;

namespace Marinares.Infrastructure.Helpers
{
	public static class PresentHelper
	{
		public static IEnumerable<Present> Get(string file)
		{
			var stream = new StreamReader(file);
			var json = stream.ReadToEnd();

			return JsonConvert.DeserializeObject<List<Present>>(json);
		}
	}
}
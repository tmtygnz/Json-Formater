using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace jsonify.src
{
	class parse
	{
		public static String parser(String jsontp)
		{
			try
			{
				dynamic jsonParsed = JsonConvert.DeserializeObject(jsontp);
				return Convert.ToString(jsonParsed);
			}
			catch(Exception e)
			{
				return e.Message;
			}
		}
	}
}

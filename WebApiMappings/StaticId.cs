using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMappings
{
	public static class StaticId
	{
		
			private static int UniqId = 0;
			public static int GetId()
        {
			UniqId++;
			return UniqId;

		}
		
	}
}
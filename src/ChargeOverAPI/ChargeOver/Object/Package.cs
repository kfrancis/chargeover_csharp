using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChargeOver
{
	public class Package : Base
	{
		public Package ()
		{
			this.line_items = new List<LineItem> ();
		}

		public int customer_id { get; set; }

		public DateTime? holduntil_datetime { get; set; }

		public List<LineItem> line_items;
	}
}


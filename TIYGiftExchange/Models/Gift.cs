using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIYGiftExchange.Models
{
	public class Gift
	{
		public int Id { get; set; }
		public string Contents { get; set; }
		public string Wrapping_Color { get; set; }
		public string GiftHint { get; set; }
		public double Height { get; set; }
		public double Width { get; set; }
		public double Depth { get; set; }
		public double Weight { get; set; }
		public bool IsOpened { get; set; }
	}
}
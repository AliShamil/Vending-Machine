using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class Product
    {
		private string? _name;
		private byte _count;


		public string? Name
		{
			get { return _name; }
			set { _name = value; }
		}


		public byte Count
		{
			get { return _count; }
			set { _count = value; }
		}

		public double Price { get; set; }


		public Product(string? name, byte count, double price)
		{
			Name=name;
			Count=count;
			Price=price;
		}

	}
}

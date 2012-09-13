using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace E002
{
	class RemoveProductFromBasket
	{
		public RemoveProductFromBasket (string product)
		{
			Product = product;
		}

		public string Product {
			get;
			set;
		}
	}

}

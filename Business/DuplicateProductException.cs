﻿using System;

namespace Business
{
	public class DuplicateProductException: Exception
	{
		public DuplicateProductException(string message): base(message)
		{
		}
	}
}


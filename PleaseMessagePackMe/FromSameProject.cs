﻿using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace PleaseMessagePackMe
{
	[MessagePackObject]
	public class FromSameProject
	{
		[Key(0)]
		public int SomeValue { get; set; }
	}
}

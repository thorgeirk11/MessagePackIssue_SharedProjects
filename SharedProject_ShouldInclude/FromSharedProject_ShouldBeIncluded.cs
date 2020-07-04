using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject_ShouldInclude
{
	[MessagePackObject]
	class FromSharedProject_ShouldBeIncluded
	{
		[Key(0)]
		public int SomeOtherValue { get; set; }
	}
}

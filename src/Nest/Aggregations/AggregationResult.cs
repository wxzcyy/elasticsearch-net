﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest
{
	[ExactContractJsonConverter(typeof(AggregationResultJsonConverter))]
	public interface IAggregationResult
	{
		IDictionary<string, object> Meta { get; set; }
	}
}

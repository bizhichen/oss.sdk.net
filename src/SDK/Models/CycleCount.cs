//
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace OneSpanSign.API
{
	
	
	internal class CycleCount
	{
		
		// Fields
		
		// Accessors
		    
    [JsonProperty("count")]
    public Nullable<Int32> Count
    {
                get; set;
        }
    
		    
    [JsonProperty("cycle")]
    public string Cycle
    {
                get; set;
        }
    
		
	
	}
}
using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct TimeUI : IAutoUnitUI {
    public float x;
    public TimeUIType type;
    
    public Time Value => this;
    
    public TimeUI(float x) {
        this.x = x;
        type = TimeUIType.Millisecond;
    }
    
    public static implicit operator float(TimeUI v) => v.Value;
    public static implicit operator Time(TimeUI v) {
	    return v.type switch {
	        TimeUIType.Millisecond => Time.Millisecond(v.x),
	        TimeUIType.Second => Time.Second(v.x),
	        TimeUIType.Minute => Time.Minute(v.x),
	        TimeUIType.Hour => Time.Hour(v.x),

		    _ => new Time(v.Value)
	    };
    }
}


public enum TimeUIType {
    [InspectorName("ms")]
    Millisecond,
    [InspectorName("s")]
    Second,
    [InspectorName("m")]
    Minute,
    [InspectorName("h")]
    Hour,

}
}

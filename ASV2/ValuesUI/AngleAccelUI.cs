using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AngleAccelUI : IAutoUnitUI {
    public float x;
    public AngleAccelUIType type;
    
    public AngleAccel Value => this;
    
    public AngleAccelUI(float x) {
        this.x = x;
        type = AngleAccelUIType.DegreesPerSecond2;
    }
    
    public static implicit operator float(AngleAccelUI v) => v.Value;
    public static implicit operator AngleAccel(AngleAccelUI v) {
	    return v.type switch {
	        AngleAccelUIType.DegreesPerSecond2 => AngleAccel.DegreesPerSecond2(v.x),
	        AngleAccelUIType.DegreesPerMinute2 => AngleAccel.DegreesPerMinute2(v.x),
	        AngleAccelUIType.RadiansPerSecond2 => AngleAccel.RadiansPerSecond2(v.x),
	        AngleAccelUIType.RadiansPerMinute2 => AngleAccel.RadiansPerMinute2(v.x),

		    _ => new AngleAccel(v.Value)
	    };
    }
}

[System.Serializable]
public struct AngleAccel2UI : IAutoUnitUI2 {
    public float x, y;
    public AngleAccelUIType type;
    
    public AngleAccel2 Value => this;
    
    public AngleAccel2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = AngleAccelUIType.DegreesPerSecond2;
    }
    
    public AngleAccel2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = AngleAccelUIType.DegreesPerSecond2;
    }
  
    public static implicit operator Vector2(AngleAccel2UI v) => v.Value;
    public static implicit operator AngleAccel2(AngleAccel2UI v) {
	    return v.type switch {
	        AngleAccelUIType.DegreesPerSecond2 => AngleAccel2.DegreesPerSecond2(v.x, v.y),
	        AngleAccelUIType.DegreesPerMinute2 => AngleAccel2.DegreesPerMinute2(v.x, v.y),
	        AngleAccelUIType.RadiansPerSecond2 => AngleAccel2.RadiansPerSecond2(v.x, v.y),
	        AngleAccelUIType.RadiansPerMinute2 => AngleAccel2.RadiansPerMinute2(v.x, v.y),

		    _ => new AngleAccel2(v.Value)
	    };
    }
}

[System.Serializable]
public struct AngleAccel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public AngleAccelUIType type;
    
    public AngleAccel3 Value => this;
    
    public AngleAccel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = AngleAccelUIType.DegreesPerSecond2;
    }

    public AngleAccel3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = AngleAccelUIType.DegreesPerSecond2;
    }

    public static implicit operator Vector3(AngleAccel3UI v) => v.Value;
    public static implicit operator AngleAccel3(AngleAccel3UI v) {
	    return v.type switch {
	        AngleAccelUIType.DegreesPerSecond2 => AngleAccel3.DegreesPerSecond2(v.x, v.y, v.z),
	        AngleAccelUIType.DegreesPerMinute2 => AngleAccel3.DegreesPerMinute2(v.x, v.y, v.z),
	        AngleAccelUIType.RadiansPerSecond2 => AngleAccel3.RadiansPerSecond2(v.x, v.y, v.z),
	        AngleAccelUIType.RadiansPerMinute2 => AngleAccel3.RadiansPerMinute2(v.x, v.y, v.z),

		    _ => new AngleAccel3(v.Value)
	    };
    }
}

public enum AngleAccelUIType {
    [InspectorName("deg╱s2")]
    DegreesPerSecond2,
    [InspectorName("deg╱m2")]
    DegreesPerMinute2,
    [InspectorName("rad╱s2")]
    RadiansPerSecond2,
    [InspectorName("rad╱m2")]
    RadiansPerMinute2,

}
}

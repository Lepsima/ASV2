using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AngleVelUI : IAutoUnitUI {
    public float x;
    public AngleVelUIType type;
    
    public AngleVel Value => this;
    
    public AngleVelUI(float x) {
        this.x = x;
        type = AngleVelUIType.DegreesPerSecond;
    }
    
    public static implicit operator float(AngleVelUI v) => v.Value;
    public static implicit operator AngleVel(AngleVelUI v) {
	    return v.type switch {
	        AngleVelUIType.DegreesPerSecond => AngleVel.DegreesPerSecond(v.x),
	        AngleVelUIType.DegreesPerMinute => AngleVel.DegreesPerMinute(v.x),
	        AngleVelUIType.RadiansPerSecond => AngleVel.RadiansPerSecond(v.x),
	        AngleVelUIType.RadiansPerMinute => AngleVel.RadiansPerMinute(v.x),

		    _ => new AngleVel(v.Value)
	    };
    }
}

[System.Serializable]
public struct AngleVel2UI : IAutoUnitUI2 {
    public float x, y;
    public AngleVelUIType type;
    
    public AngleVel2 Value => this;
    
    public AngleVel2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = AngleVelUIType.DegreesPerSecond;
    }
    
    public AngleVel2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = AngleVelUIType.DegreesPerSecond;
    }
  
    public static implicit operator Vector2(AngleVel2UI v) => v.Value;
    public static implicit operator AngleVel2(AngleVel2UI v) {
	    return v.type switch {
	        AngleVelUIType.DegreesPerSecond => AngleVel2.DegreesPerSecond(v.x, v.y),
	        AngleVelUIType.DegreesPerMinute => AngleVel2.DegreesPerMinute(v.x, v.y),
	        AngleVelUIType.RadiansPerSecond => AngleVel2.RadiansPerSecond(v.x, v.y),
	        AngleVelUIType.RadiansPerMinute => AngleVel2.RadiansPerMinute(v.x, v.y),

		    _ => new AngleVel2(v.Value)
	    };
    }
}

[System.Serializable]
public struct AngleVel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public AngleVelUIType type;
    
    public AngleVel3 Value => this;
    
    public AngleVel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = AngleVelUIType.DegreesPerSecond;
    }

    public AngleVel3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = AngleVelUIType.DegreesPerSecond;
    }

    public static implicit operator Vector3(AngleVel3UI v) => v.Value;
    public static implicit operator AngleVel3(AngleVel3UI v) {
	    return v.type switch {
	        AngleVelUIType.DegreesPerSecond => AngleVel3.DegreesPerSecond(v.x, v.y, v.z),
	        AngleVelUIType.DegreesPerMinute => AngleVel3.DegreesPerMinute(v.x, v.y, v.z),
	        AngleVelUIType.RadiansPerSecond => AngleVel3.RadiansPerSecond(v.x, v.y, v.z),
	        AngleVelUIType.RadiansPerMinute => AngleVel3.RadiansPerMinute(v.x, v.y, v.z),

		    _ => new AngleVel3(v.Value)
	    };
    }
}

public enum AngleVelUIType {
    [InspectorName("deg╱s")]
    DegreesPerSecond,
    [InspectorName("deg╱m")]
    DegreesPerMinute,
    [InspectorName("rad╱s")]
    RadiansPerSecond,
    [InspectorName("rad╱m")]
    RadiansPerMinute,

}
}

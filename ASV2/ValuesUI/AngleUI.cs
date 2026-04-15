using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AngleUI : IAutoUnitUI {
    public float x;
    public AngleUIType type;
    
    public Angle Value => this;
    
    public AngleUI(float x) {
        this.x = x;
        type = AngleUIType.Degree;
    }
    
    public static implicit operator float(AngleUI v) => v.Value;
    public static implicit operator Angle(AngleUI v) {
	    return v.type switch {
	        AngleUIType.Degree => Angle.Degree(v.x),
	        AngleUIType.Radian => Angle.Radian(v.x),

		    _ => new Angle(v.Value)
	    };
    }
}

[System.Serializable]
public struct Angle2UI : IAutoUnitUI2 {
    public float x, y;
    public AngleUIType type;
    
    public Angle2 Value => this;
    
    public Angle2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = AngleUIType.Degree;
    }
    
    public Angle2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = AngleUIType.Degree;
    }
  
    public static implicit operator Vector2(Angle2UI v) => v.Value;
    public static implicit operator Angle2(Angle2UI v) {
	    return v.type switch {
	        AngleUIType.Degree => Angle2.Degree(v.x, v.y),
	        AngleUIType.Radian => Angle2.Radian(v.x, v.y),

		    _ => new Angle2(v.Value)
	    };
    }
}

[System.Serializable]
public struct Angle3UI : IAutoUnitUI3 {
    public float x, y, z;
    public AngleUIType type;
    
    public Angle3 Value => this;
    
    public Angle3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = AngleUIType.Degree;
    }

    public Angle3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = AngleUIType.Degree;
    }

    public static implicit operator Vector3(Angle3UI v) => v.Value;
    public static implicit operator Angle3(Angle3UI v) {
	    return v.type switch {
	        AngleUIType.Degree => Angle3.Degree(v.x, v.y, v.z),
	        AngleUIType.Radian => Angle3.Radian(v.x, v.y, v.z),

		    _ => new Angle3(v.Value)
	    };
    }
}

public enum AngleUIType {
    [InspectorName("deg")]
    Degree,
    [InspectorName("rad")]
    Radian,

}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct ForceUI : IAutoUnitUI {
    public float x;
    public ForceUIType type;
    
    public Force Value => this;
    
    public ForceUI(float x) {
        this.x = x;
        type = ForceUIType.Newton;
    }
    
    public static implicit operator float(ForceUI v) => v.Value;
    public static implicit operator Force(ForceUI v) {
	    return v.type switch {
	        ForceUIType.Newton => Force.Newton(v.x),
	        ForceUIType.Kilonewton => Force.Kilonewton(v.x),
	        ForceUIType.Meganewton => Force.Meganewton(v.x),

		    _ => new Force(v.Value)
	    };
    }
}

[System.Serializable]
public struct Force2UI : IAutoUnitUI2 {
    public float x, y;
    public ForceUIType type;
    
    public Force2 Value => this;
    
    public Force2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = ForceUIType.Newton;
    }
    
    public Force2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = ForceUIType.Newton;
    }
  
    public static implicit operator Vector2(Force2UI v) => v.Value;
    public static implicit operator Force2(Force2UI v) {
	    return v.type switch {
	        ForceUIType.Newton => Force2.Newton(v.x, v.y),
	        ForceUIType.Kilonewton => Force2.Kilonewton(v.x, v.y),
	        ForceUIType.Meganewton => Force2.Meganewton(v.x, v.y),

		    _ => new Force2(v.Value)
	    };
    }
}

[System.Serializable]
public struct Force3UI : IAutoUnitUI3 {
    public float x, y, z;
    public ForceUIType type;
    
    public Force3 Value => this;
    
    public Force3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = ForceUIType.Newton;
    }

    public Force3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = ForceUIType.Newton;
    }

    public static implicit operator Vector3(Force3UI v) => v.Value;
    public static implicit operator Force3(Force3UI v) {
	    return v.type switch {
	        ForceUIType.Newton => Force3.Newton(v.x, v.y, v.z),
	        ForceUIType.Kilonewton => Force3.Kilonewton(v.x, v.y, v.z),
	        ForceUIType.Meganewton => Force3.Meganewton(v.x, v.y, v.z),

		    _ => new Force3(v.Value)
	    };
    }
}

public enum ForceUIType {
    [InspectorName("N")]
    Newton,
    [InspectorName("kN")]
    Kilonewton,
    [InspectorName("MN")]
    Meganewton,

}
}

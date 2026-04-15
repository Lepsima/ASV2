using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct ForceAccelUI : IAutoUnitUI {
    public float x;
    public ForceAccelUIType type;
    
    public ForceAccel Value => this;
    
    public ForceAccelUI(float x) {
        this.x = x;
        type = ForceAccelUIType.NewtonsPerSecond;
    }
    
    public static implicit operator float(ForceAccelUI v) => v.Value;
    public static implicit operator ForceAccel(ForceAccelUI v) {
	    return v.type switch {
	        ForceAccelUIType.NewtonsPerSecond => ForceAccel.NewtonsPerSecond(v.x),
	        ForceAccelUIType.KilonewtonsPerSecond => ForceAccel.KilonewtonsPerSecond(v.x),

		    _ => new ForceAccel(v.Value)
	    };
    }
}

[System.Serializable]
public struct ForceAccel2UI : IAutoUnitUI2 {
    public float x, y;
    public ForceAccelUIType type;
    
    public ForceAccel2 Value => this;
    
    public ForceAccel2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = ForceAccelUIType.NewtonsPerSecond;
    }
    
    public ForceAccel2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = ForceAccelUIType.NewtonsPerSecond;
    }
  
    public static implicit operator Vector2(ForceAccel2UI v) => v.Value;
    public static implicit operator ForceAccel2(ForceAccel2UI v) {
	    return v.type switch {
	        ForceAccelUIType.NewtonsPerSecond => ForceAccel2.NewtonsPerSecond(v.x, v.y),
	        ForceAccelUIType.KilonewtonsPerSecond => ForceAccel2.KilonewtonsPerSecond(v.x, v.y),

		    _ => new ForceAccel2(v.Value)
	    };
    }
}

[System.Serializable]
public struct ForceAccel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public ForceAccelUIType type;
    
    public ForceAccel3 Value => this;
    
    public ForceAccel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = ForceAccelUIType.NewtonsPerSecond;
    }

    public ForceAccel3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = ForceAccelUIType.NewtonsPerSecond;
    }

    public static implicit operator Vector3(ForceAccel3UI v) => v.Value;
    public static implicit operator ForceAccel3(ForceAccel3UI v) {
	    return v.type switch {
	        ForceAccelUIType.NewtonsPerSecond => ForceAccel3.NewtonsPerSecond(v.x, v.y, v.z),
	        ForceAccelUIType.KilonewtonsPerSecond => ForceAccel3.KilonewtonsPerSecond(v.x, v.y, v.z),

		    _ => new ForceAccel3(v.Value)
	    };
    }
}

public enum ForceAccelUIType {
    [InspectorName("N╱s")]
    NewtonsPerSecond,
    [InspectorName("kN╱s")]
    KilonewtonsPerSecond,

}
}

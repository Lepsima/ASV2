using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct TorqueAccelUI : IAutoUnitUI {
    public float x;
    public TorqueAccelUIType type;
    
    public TorqueAccel Value => this;
    
    public TorqueAccelUI(float x) {
        this.x = x;
        type = TorqueAccelUIType.NewtonsPerMetersPerSecond;
    }
    
    public static implicit operator float(TorqueAccelUI v) => v.Value;
    public static implicit operator TorqueAccel(TorqueAccelUI v) {
	    return v.type switch {
	        TorqueAccelUIType.NewtonsPerMetersPerSecond => TorqueAccel.NewtonsPerMetersPerSecond(v.x),
	        TorqueAccelUIType.KilonewtonsPerMetersPerSecond => TorqueAccel.KilonewtonsPerMetersPerSecond(v.x),

		    _ => new TorqueAccel(v.Value)
	    };
    }
}

[System.Serializable]
public struct TorqueAccel2UI : IAutoUnitUI2 {
    public float x, y;
    public TorqueAccelUIType type;
    
    public TorqueAccel2 Value => this;
    
    public TorqueAccel2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = TorqueAccelUIType.NewtonsPerMetersPerSecond;
    }
    
    public TorqueAccel2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = TorqueAccelUIType.NewtonsPerMetersPerSecond;
    }
  
    public static implicit operator Vector2(TorqueAccel2UI v) => v.Value;
    public static implicit operator TorqueAccel2(TorqueAccel2UI v) {
	    return v.type switch {
	        TorqueAccelUIType.NewtonsPerMetersPerSecond => TorqueAccel2.NewtonsPerMetersPerSecond(v.x, v.y),
	        TorqueAccelUIType.KilonewtonsPerMetersPerSecond => TorqueAccel2.KilonewtonsPerMetersPerSecond(v.x, v.y),

		    _ => new TorqueAccel2(v.Value)
	    };
    }
}

[System.Serializable]
public struct TorqueAccel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public TorqueAccelUIType type;
    
    public TorqueAccel3 Value => this;
    
    public TorqueAccel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = TorqueAccelUIType.NewtonsPerMetersPerSecond;
    }

    public TorqueAccel3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = TorqueAccelUIType.NewtonsPerMetersPerSecond;
    }

    public static implicit operator Vector3(TorqueAccel3UI v) => v.Value;
    public static implicit operator TorqueAccel3(TorqueAccel3UI v) {
	    return v.type switch {
	        TorqueAccelUIType.NewtonsPerMetersPerSecond => TorqueAccel3.NewtonsPerMetersPerSecond(v.x, v.y, v.z),
	        TorqueAccelUIType.KilonewtonsPerMetersPerSecond => TorqueAccel3.KilonewtonsPerMetersPerSecond(v.x, v.y, v.z),

		    _ => new TorqueAccel3(v.Value)
	    };
    }
}

public enum TorqueAccelUIType {
    [InspectorName("N*m╱s")]
    NewtonsPerMetersPerSecond,
    [InspectorName("kN*m╱s")]
    KilonewtonsPerMetersPerSecond,

}
}

using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct TorqueUI : IAutoUnitUI {
    public float x;
    public TorqueUIType type;
    
    public Torque Value => this;
    
    public TorqueUI(float x) {
        this.x = x;
        type = TorqueUIType.NewtonsPerMeter;
    }
    
    public static implicit operator float(TorqueUI v) => v.Value;
    public static implicit operator Torque(TorqueUI v) {
	    return v.type switch {
	        TorqueUIType.NewtonsPerMeter => Torque.NewtonsPerMeter(v.x),
	        TorqueUIType.KilonewtonsPerMeter => Torque.KilonewtonsPerMeter(v.x),

		    _ => new Torque(v.Value)
	    };
    }
}

[System.Serializable]
public struct Torque2UI : IAutoUnitUI2 {
    public float x, y;
    public TorqueUIType type;
    
    public Torque2 Value => this;
    
    public Torque2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = TorqueUIType.NewtonsPerMeter;
    }
    
    public Torque2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = TorqueUIType.NewtonsPerMeter;
    }
  
    public static implicit operator Vector2(Torque2UI v) => v.Value;
    public static implicit operator Torque2(Torque2UI v) {
	    return v.type switch {
	        TorqueUIType.NewtonsPerMeter => Torque2.NewtonsPerMeter(v.x, v.y),
	        TorqueUIType.KilonewtonsPerMeter => Torque2.KilonewtonsPerMeter(v.x, v.y),

		    _ => new Torque2(v.Value)
	    };
    }
}

[System.Serializable]
public struct Torque3UI : IAutoUnitUI3 {
    public float x, y, z;
    public TorqueUIType type;
    
    public Torque3 Value => this;
    
    public Torque3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = TorqueUIType.NewtonsPerMeter;
    }

    public Torque3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = TorqueUIType.NewtonsPerMeter;
    }

    public static implicit operator Vector3(Torque3UI v) => v.Value;
    public static implicit operator Torque3(Torque3UI v) {
	    return v.type switch {
	        TorqueUIType.NewtonsPerMeter => Torque3.NewtonsPerMeter(v.x, v.y, v.z),
	        TorqueUIType.KilonewtonsPerMeter => Torque3.KilonewtonsPerMeter(v.x, v.y, v.z),

		    _ => new Torque3(v.Value)
	    };
    }
}

public enum TorqueUIType {
    [InspectorName("N*m")]
    NewtonsPerMeter,
    [InspectorName("kN*m")]
    KilonewtonsPerMeter,

}
}

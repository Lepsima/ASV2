using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct AccelUI : IAutoUnitUI {
    public float x;
    public AccelUIType type;
    
    public Accel Value => this;
    
    public AccelUI(float x) {
        this.x = x;
        type = AccelUIType.MetersPerSecond2;
    }
    
    public static implicit operator float(AccelUI v) => v.Value;
    public static implicit operator Accel(AccelUI v) {
	    return v.type switch {
	        AccelUIType.MetersPerSecond2 => Accel.MetersPerSecond2(v.x),
	        AccelUIType.KilometersPerHour2 => Accel.KilometersPerHour2(v.x),
	        AccelUIType.FeetsPerSecond2 => Accel.FeetsPerSecond2(v.x),
	        AccelUIType.MilesPerHour2 => Accel.MilesPerHour2(v.x),

		    _ => new Accel(v.Value)
	    };
    }
}

[System.Serializable]
public struct Accel2UI : IAutoUnitUI2 {
    public float x, y;
    public AccelUIType type;
    
    public Accel2 Value => this;
    
    public Accel2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = AccelUIType.MetersPerSecond2;
    }
    
    public Accel2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = AccelUIType.MetersPerSecond2;
    }
  
    public static implicit operator Vector2(Accel2UI v) => v.Value;
    public static implicit operator Accel2(Accel2UI v) {
	    return v.type switch {
	        AccelUIType.MetersPerSecond2 => Accel2.MetersPerSecond2(v.x, v.y),
	        AccelUIType.KilometersPerHour2 => Accel2.KilometersPerHour2(v.x, v.y),
	        AccelUIType.FeetsPerSecond2 => Accel2.FeetsPerSecond2(v.x, v.y),
	        AccelUIType.MilesPerHour2 => Accel2.MilesPerHour2(v.x, v.y),

		    _ => new Accel2(v.Value)
	    };
    }
}

[System.Serializable]
public struct Accel3UI : IAutoUnitUI3 {
    public float x, y, z;
    public AccelUIType type;
    
    public Accel3 Value => this;
    
    public Accel3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = AccelUIType.MetersPerSecond2;
    }

    public Accel3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = AccelUIType.MetersPerSecond2;
    }

    public static implicit operator Vector3(Accel3UI v) => v.Value;
    public static implicit operator Accel3(Accel3UI v) {
	    return v.type switch {
	        AccelUIType.MetersPerSecond2 => Accel3.MetersPerSecond2(v.x, v.y, v.z),
	        AccelUIType.KilometersPerHour2 => Accel3.KilometersPerHour2(v.x, v.y, v.z),
	        AccelUIType.FeetsPerSecond2 => Accel3.FeetsPerSecond2(v.x, v.y, v.z),
	        AccelUIType.MilesPerHour2 => Accel3.MilesPerHour2(v.x, v.y, v.z),

		    _ => new Accel3(v.Value)
	    };
    }
}

public enum AccelUIType {
    [InspectorName("m╱s2")]
    MetersPerSecond2,
    [InspectorName("km╱h2")]
    KilometersPerHour2,
    [InspectorName("ft╱s2")]
    FeetsPerSecond2,
    [InspectorName("mi╱h2")]
    MilesPerHour2,

}
}

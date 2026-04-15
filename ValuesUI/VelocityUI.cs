using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct VelocityUI : IAutoUnitUI {
    public float x;
    public VelocityUIType type;
    
    public Velocity Value => this;
    
    public VelocityUI(float x) {
        this.x = x;
        type = VelocityUIType.MetersPerSecond;
    }
    
    public static implicit operator float(VelocityUI v) => v.Value;
    public static implicit operator Velocity(VelocityUI v) {
	    return v.type switch {
	        VelocityUIType.MetersPerSecond => Velocity.MetersPerSecond(v.x),
	        VelocityUIType.KilometersPerHour => Velocity.KilometersPerHour(v.x),
	        VelocityUIType.FeetsPerSecond => Velocity.FeetsPerSecond(v.x),
	        VelocityUIType.MilesPerHour => Velocity.MilesPerHour(v.x),

		    _ => new Velocity(v.Value)
	    };
    }
}

[System.Serializable]
public struct Velocity2UI : IAutoUnitUI2 {
    public float x, y;
    public VelocityUIType type;
    
    public Velocity2 Value => this;
    
    public Velocity2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = VelocityUIType.MetersPerSecond;
    }
    
    public Velocity2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = VelocityUIType.MetersPerSecond;
    }
  
    public static implicit operator Vector2(Velocity2UI v) => v.Value;
    public static implicit operator Velocity2(Velocity2UI v) {
	    return v.type switch {
	        VelocityUIType.MetersPerSecond => Velocity2.MetersPerSecond(v.x, v.y),
	        VelocityUIType.KilometersPerHour => Velocity2.KilometersPerHour(v.x, v.y),
	        VelocityUIType.FeetsPerSecond => Velocity2.FeetsPerSecond(v.x, v.y),
	        VelocityUIType.MilesPerHour => Velocity2.MilesPerHour(v.x, v.y),

		    _ => new Velocity2(v.Value)
	    };
    }
}

[System.Serializable]
public struct Velocity3UI : IAutoUnitUI3 {
    public float x, y, z;
    public VelocityUIType type;
    
    public Velocity3 Value => this;
    
    public Velocity3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = VelocityUIType.MetersPerSecond;
    }

    public Velocity3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = VelocityUIType.MetersPerSecond;
    }

    public static implicit operator Vector3(Velocity3UI v) => v.Value;
    public static implicit operator Velocity3(Velocity3UI v) {
	    return v.type switch {
	        VelocityUIType.MetersPerSecond => Velocity3.MetersPerSecond(v.x, v.y, v.z),
	        VelocityUIType.KilometersPerHour => Velocity3.KilometersPerHour(v.x, v.y, v.z),
	        VelocityUIType.FeetsPerSecond => Velocity3.FeetsPerSecond(v.x, v.y, v.z),
	        VelocityUIType.MilesPerHour => Velocity3.MilesPerHour(v.x, v.y, v.z),

		    _ => new Velocity3(v.Value)
	    };
    }
}

public enum VelocityUIType {
    [InspectorName("m╱s")]
    MetersPerSecond,
    [InspectorName("km╱h")]
    KilometersPerHour,
    [InspectorName("ft╱s")]
    FeetsPerSecond,
    [InspectorName("mi╱h")]
    MilesPerHour,

}
}

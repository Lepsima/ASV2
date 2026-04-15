using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct PositionUI : IAutoUnitUI {
    public float x;
    public PositionUIType type;
    
    public Position Value => this;
    
    public PositionUI(float x) {
        this.x = x;
        type = PositionUIType.Feet;
    }
    
    public static implicit operator float(PositionUI v) => v.Value;
    public static implicit operator Position(PositionUI v) {
	    return v.type switch {
	        PositionUIType.Feet => Position.Feet(v.x),
	        PositionUIType.Mile => Position.Mile(v.x),
	        PositionUIType.Centimeter => Position.Centimeter(v.x),
	        PositionUIType.Meter => Position.Meter(v.x),
	        PositionUIType.Kilometer => Position.Kilometer(v.x),

		    _ => new Position(v.Value)
	    };
    }
}

[System.Serializable]
public struct Position2UI : IAutoUnitUI2 {
    public float x, y;
    public PositionUIType type;
    
    public Position2 Value => this;
    
    public Position2UI(float x, float y) {
        this.x = x;
        this.y = y;
        type = PositionUIType.Feet;
    }
    
    public Position2UI(Vector2 v2) {
        x = v2.x;
        y = v2.y;
        type = PositionUIType.Feet;
    }
  
    public static implicit operator Vector2(Position2UI v) => v.Value;
    public static implicit operator Position2(Position2UI v) {
	    return v.type switch {
	        PositionUIType.Feet => Position2.Feet(v.x, v.y),
	        PositionUIType.Mile => Position2.Mile(v.x, v.y),
	        PositionUIType.Centimeter => Position2.Centimeter(v.x, v.y),
	        PositionUIType.Meter => Position2.Meter(v.x, v.y),
	        PositionUIType.Kilometer => Position2.Kilometer(v.x, v.y),

		    _ => new Position2(v.Value)
	    };
    }
}

[System.Serializable]
public struct Position3UI : IAutoUnitUI3 {
    public float x, y, z;
    public PositionUIType type;
    
    public Position3 Value => this;
    
    public Position3UI(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
        type = PositionUIType.Feet;
    }

    public Position3UI(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
        type = PositionUIType.Feet;
    }

    public static implicit operator Vector3(Position3UI v) => v.Value;
    public static implicit operator Position3(Position3UI v) {
	    return v.type switch {
	        PositionUIType.Feet => Position3.Feet(v.x, v.y, v.z),
	        PositionUIType.Mile => Position3.Mile(v.x, v.y, v.z),
	        PositionUIType.Centimeter => Position3.Centimeter(v.x, v.y, v.z),
	        PositionUIType.Meter => Position3.Meter(v.x, v.y, v.z),
	        PositionUIType.Kilometer => Position3.Kilometer(v.x, v.y, v.z),

		    _ => new Position3(v.Value)
	    };
    }
}

public enum PositionUIType {
    [InspectorName("ft")]
    Feet,
    [InspectorName("mi")]
    Mile,
    [InspectorName("cm")]
    Centimeter,
    [InspectorName("m")]
    Meter,
    [InspectorName("km")]
    Kilometer,

}
}

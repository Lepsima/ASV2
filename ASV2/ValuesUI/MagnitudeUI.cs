using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct MagnitudeUI : IAutoUnitUI {
    public float x;
    public MagnitudeUIType type;
    
    public Magnitude Value => this;
    
    public MagnitudeUI(float x) {
        this.x = x;
        type = MagnitudeUIType.ZeroToOne;
    }
    
    public static implicit operator float(MagnitudeUI v) => v.Value;
    public static implicit operator Magnitude(MagnitudeUI v) {
	    return v.type switch {
	        MagnitudeUIType.ZeroToOne => Magnitude.ZeroToOne(v.x),

		    _ => new Magnitude(v.Value)
	    };
    }
}


public enum MagnitudeUIType {
    [InspectorName("mag")]
    ZeroToOne,

}
}

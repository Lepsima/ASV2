using System;
using UnityEngine;

namespace Lepsima.ASV {
[System.Serializable]
public struct MassUI : IAutoUnitUI {
    public float x;
    public MassUIType type;
    
    public Mass Value => this;
    
    public MassUI(float x) {
        this.x = x;
        type = MassUIType.Gram;
    }
    
    public static implicit operator float(MassUI v) => v.Value;
    public static implicit operator Mass(MassUI v) {
	    return v.type switch {
	        MassUIType.Gram => Mass.Gram(v.x),
	        MassUIType.Kilogram => Mass.Kilogram(v.x),
	        MassUIType.Ton => Mass.Ton(v.x),

		    _ => new Mass(v.Value)
	    };
    }
}


public enum MassUIType {
    [InspectorName("g")]
    Gram,
    [InspectorName("kg")]
    Kilogram,
    [InspectorName("t")]
    Ton,

}
}

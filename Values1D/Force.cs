using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Force : IAutoUnit {
    public float x;
    
    public Force(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(Force v) => v.x;

    public float ToMillinewton() => x * 1000f;
    public static Force Millinewton(float x) => new(x * 0.001f);

    public float ToNewton() => x * 1f;
    public static Force Newton(float x) => new(x * 1f);

    public float ToKilonewton() => x * 0.001f;
    public static Force Kilonewton(float x) => new(x * 1000f);

    public float ToMeganewton() => x * 1E-06f;
    public static Force Meganewton(float x) => new(x * 1000000f);

    public static Force operator +(Force a, Force b) => new(a.x + b.x);
    public static Force operator -(Force a, Force b) => new(a.x - b.x);
    
    public static Force operator *(Force a, Force b) => new(a.x * b.x);
    public static Force operator /(Force a, Force b) => new(a.x / b.x);
    
    public Accel Accel(Mass v) => new(x / v);
    public Mass Mass(Accel v) => new(x / v);

    public Force(Accel a, Mass b) : this(a.Force(b)) { }
    public Force(Mass b, Accel a) : this(a.Force(b)) { }

    public static Force operator +(ForceAccel a, Force b) => b + a.Force(VTime.deltaTime);
    public static Force operator +(Force b, ForceAccel a) => b + a.Force(VTime.deltaTime);
    public static Force operator -(ForceAccel a, Force b) => a.Force(VTime.deltaTime) - b;
    public static Force operator -(Force b, ForceAccel a) => b - a.Force(VTime.deltaTime);
    
    public ForceAccel ForceAccel(Time v) => new(x / v);
    public Time Time(ForceAccel v) => new(x / v);

    public Force(ForceAccel a, Time b) : this(a.Force(b)) { }
    public Force(Time b, ForceAccel a) : this(a.Force(b)) { }

    public Torque Torque(Position v) => new(v.x * x);
    public Position Position(Torque v) => new(v.x / x);

    public Force(Torque a, Position b) : this(a.Force(b)) { }
    public Force(Position b, Torque a) : this(a.Force(b)) { }

}
}

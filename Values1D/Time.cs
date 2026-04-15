using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Time : IAutoUnit {
    public float x;
    
    public Time(float x) {
        this.x = x;
    }
    
    public float vector => x;
    
    public static implicit operator float(Time v) => v.x;
    public Time magnitude => new(x);

    public float ToMicrosecond() => x * 1000000f;
    public static Time Microsecond(float x) => new(x * 1E-06f);

    public float ToMillisecond() => x * 1000f;
    public static Time Millisecond(float x) => new(x * 0.001f);

    public float ToSecond() => x * 1f;
    public static Time Second(float x) => new(x * 1f);

    public float ToMinute() => x * 0.01666666667f;
    public static Time Minute(float x) => new(x * 60f);

    public float ToHour() => x * 0.0002777777778f;
    public static Time Hour(float x) => new(x * 3600f);

    public static Time operator +(Time a, Time b) => new(a.x + b.x);
    public static Time operator -(Time a, Time b) => new(a.x - b.x);
    
    public static Time operator *(Time a, Time b) => new(a.x * b.x);
    public static Time operator /(Time a, Time b) => new(a.x / b.x);
    
    public Position Position(Velocity v) => new(v.x * x);
    public Velocity Velocity(Position v) => new(v.x / x);

    public Time(Position a, Velocity b) : this(a.Time(b)) { }
    public Time(Velocity b, Position a) : this(a.Time(b)) { }

    public Velocity Velocity(Accel v) => new(v.x * x);
    public Accel Accel(Velocity v) => new(v.x / x);

    public Time(Velocity a, Accel b) : this(a.Time(b)) { }
    public Time(Accel b, Velocity a) : this(a.Time(b)) { }

    public Force Force(ForceAccel v) => new(v.x * x);
    public ForceAccel ForceAccel(Force v) => new(v.x / x);

    public Time(Force a, ForceAccel b) : this(a.Time(b)) { }
    public Time(ForceAccel b, Force a) : this(a.Time(b)) { }

    public Angle Angle(AngleVel v) => new(v.x * x);
    public AngleVel AngleVel(Angle v) => new(v.x / x);

    public Time(Angle a, AngleVel b) : this(a.Time(b)) { }
    public Time(AngleVel b, Angle a) : this(a.Time(b)) { }

    public AngleVel AngleVel(AngleAccel v) => new(v.x * x);
    public AngleAccel AngleAccel(AngleVel v) => new(v.x / x);

    public Time(AngleVel a, AngleAccel b) : this(a.Time(b)) { }
    public Time(AngleAccel b, AngleVel a) : this(a.Time(b)) { }

    public Torque Torque(TorqueAccel v) => new(v.x * x);
    public TorqueAccel TorqueAccel(Torque v) => new(v.x / x);

    public Time(Torque a, TorqueAccel b) : this(a.Time(b)) { }
    public Time(TorqueAccel b, Torque a) : this(a.Time(b)) { }

}
}

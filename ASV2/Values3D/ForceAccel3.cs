using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct ForceAccel3 : IAutoUnit3 {
    public float x, y, z;
    
    public ForceAccel3(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    
    public ForceAccel3(Vector3 v3) {
        x = v3.x;
        y = v3.y;
        z = v3.z;
    }
    
    public Vector3 vector => this;
    public static implicit operator Vector3(ForceAccel3 v) => new(v.x, v.y, v.z);
    
    public Direction3 normalized => new(vector.normalized);
    public ForceAccel sqrMagnitude => new(vector.sqrMagnitude);
    public ForceAccel magnitude => new(vector.magnitude);

    public Vector3 ToMillinewtonsPerMicrosecond() => new(x * 0.001f, y * 0.001f, z * 0.001f);
    public static ForceAccel3 MillinewtonsPerMicrosecond(float x, float y, float z) => new(x * 1000f, y * 1000f, z * 1000f);
    public static ForceAccel3 MillinewtonsPerMicrosecond(Vector3 v) => new(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToMillinewtonsPerMillisecond() => new(x * 1f, y * 1f, z * 1f);
    public static ForceAccel3 MillinewtonsPerMillisecond(float x, float y, float z) => new(x * 1f, y * 1f, z * 1f);
    public static ForceAccel3 MillinewtonsPerMillisecond(Vector3 v) => new(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToMillinewtonsPerSecond() => new(x * 1000f, y * 1000f, z * 1000f);
    public static ForceAccel3 MillinewtonsPerSecond(float x, float y, float z) => new(x * 0.001f, y * 0.001f, z * 0.001f);
    public static ForceAccel3 MillinewtonsPerSecond(Vector3 v) => new(v.x * 0.001f, v.y * 0.001f, v.z * 0.001f);

    public Vector3 ToMillinewtonsPerMinute() => new(x * 60000f, y * 60000f, z * 60000f);
    public static ForceAccel3 MillinewtonsPerMinute(float x, float y, float z) => new(x * 1.666666667E-05f, y * 1.666666667E-05f, z * 1.666666667E-05f);
    public static ForceAccel3 MillinewtonsPerMinute(Vector3 v) => new(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f, v.z * 1.666666667E-05f);

    public Vector3 ToMillinewtonsPerHour() => new(x * 3600000f, y * 3600000f, z * 3600000f);
    public static ForceAccel3 MillinewtonsPerHour(float x, float y, float z) => new(x * 2.777777778E-07f, y * 2.777777778E-07f, z * 2.777777778E-07f);
    public static ForceAccel3 MillinewtonsPerHour(Vector3 v) => new(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f, v.z * 2.777777778E-07f);

    public Vector3 ToNewtonsPerMicrosecond() => new(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static ForceAccel3 NewtonsPerMicrosecond(float x, float y, float z) => new(x * 1000000f, y * 1000000f, z * 1000000f);
    public static ForceAccel3 NewtonsPerMicrosecond(Vector3 v) => new(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToNewtonsPerMillisecond() => new(x * 0.001f, y * 0.001f, z * 0.001f);
    public static ForceAccel3 NewtonsPerMillisecond(float x, float y, float z) => new(x * 1000f, y * 1000f, z * 1000f);
    public static ForceAccel3 NewtonsPerMillisecond(Vector3 v) => new(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToNewtonsPerSecond() => new(x * 1f, y * 1f, z * 1f);
    public static ForceAccel3 NewtonsPerSecond(float x, float y, float z) => new(x * 1f, y * 1f, z * 1f);
    public static ForceAccel3 NewtonsPerSecond(Vector3 v) => new(v.x * 1f, v.y * 1f, v.z * 1f);

    public Vector3 ToNewtonsPerMinute() => new(x * 60f, y * 60f, z * 60f);
    public static ForceAccel3 NewtonsPerMinute(float x, float y, float z) => new(x * 0.01666666667f, y * 0.01666666667f, z * 0.01666666667f);
    public static ForceAccel3 NewtonsPerMinute(Vector3 v) => new(v.x * 0.01666666667f, v.y * 0.01666666667f, v.z * 0.01666666667f);

    public Vector3 ToNewtonsPerHour() => new(x * 3600f, y * 3600f, z * 3600f);
    public static ForceAccel3 NewtonsPerHour(float x, float y, float z) => new(x * 0.0002777777778f, y * 0.0002777777778f, z * 0.0002777777778f);
    public static ForceAccel3 NewtonsPerHour(Vector3 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f, v.z * 0.0002777777778f);

    public Vector3 ToKilonewtonsPerMicrosecond() => new(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static ForceAccel3 KilonewtonsPerMicrosecond(float x, float y, float z) => new(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static ForceAccel3 KilonewtonsPerMicrosecond(Vector3 v) => new(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToKilonewtonsPerMillisecond() => new(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static ForceAccel3 KilonewtonsPerMillisecond(float x, float y, float z) => new(x * 1000000f, y * 1000000f, z * 1000000f);
    public static ForceAccel3 KilonewtonsPerMillisecond(Vector3 v) => new(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToKilonewtonsPerSecond() => new(x * 0.001f, y * 0.001f, z * 0.001f);
    public static ForceAccel3 KilonewtonsPerSecond(float x, float y, float z) => new(x * 1000f, y * 1000f, z * 1000f);
    public static ForceAccel3 KilonewtonsPerSecond(Vector3 v) => new(v.x * 1000f, v.y * 1000f, v.z * 1000f);

    public Vector3 ToKilonewtonsPerMinute() => new(x * 0.06f, y * 0.06f, z * 0.06f);
    public static ForceAccel3 KilonewtonsPerMinute(float x, float y, float z) => new(x * 16.66666667f, y * 16.66666667f, z * 16.66666667f);
    public static ForceAccel3 KilonewtonsPerMinute(Vector3 v) => new(v.x * 16.66666667f, v.y * 16.66666667f, v.z * 16.66666667f);

    public Vector3 ToKilonewtonsPerHour() => new(x * 3.6f, y * 3.6f, z * 3.6f);
    public static ForceAccel3 KilonewtonsPerHour(float x, float y, float z) => new(x * 0.2777777778f, y * 0.2777777778f, z * 0.2777777778f);
    public static ForceAccel3 KilonewtonsPerHour(Vector3 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f, v.z * 0.2777777778f);

    public Vector3 ToMeganewtonsPerMicrosecond() => new(x * 1E-12f, y * 1E-12f, z * 1E-12f);
    public static ForceAccel3 MeganewtonsPerMicrosecond(float x, float y, float z) => new(x * 1E+12f, y * 1E+12f, z * 1E+12f);
    public static ForceAccel3 MeganewtonsPerMicrosecond(Vector3 v) => new(v.x * 1E+12f, v.y * 1E+12f, v.z * 1E+12f);

    public Vector3 ToMeganewtonsPerMillisecond() => new(x * 1E-09f, y * 1E-09f, z * 1E-09f);
    public static ForceAccel3 MeganewtonsPerMillisecond(float x, float y, float z) => new(x * 1000000000f, y * 1000000000f, z * 1000000000f);
    public static ForceAccel3 MeganewtonsPerMillisecond(Vector3 v) => new(v.x * 1000000000f, v.y * 1000000000f, v.z * 1000000000f);

    public Vector3 ToMeganewtonsPerSecond() => new(x * 1E-06f, y * 1E-06f, z * 1E-06f);
    public static ForceAccel3 MeganewtonsPerSecond(float x, float y, float z) => new(x * 1000000f, y * 1000000f, z * 1000000f);
    public static ForceAccel3 MeganewtonsPerSecond(Vector3 v) => new(v.x * 1000000f, v.y * 1000000f, v.z * 1000000f);

    public Vector3 ToMeganewtonsPerMinute() => new(x * 6E-05f, y * 6E-05f, z * 6E-05f);
    public static ForceAccel3 MeganewtonsPerMinute(float x, float y, float z) => new(x * 16666.66667f, y * 16666.66667f, z * 16666.66667f);
    public static ForceAccel3 MeganewtonsPerMinute(Vector3 v) => new(v.x * 16666.66667f, v.y * 16666.66667f, v.z * 16666.66667f);

    public Vector3 ToMeganewtonsPerHour() => new(x * 0.0036f, y * 0.0036f, z * 0.0036f);
    public static ForceAccel3 MeganewtonsPerHour(float x, float y, float z) => new(x * 277.7777778f, y * 277.7777778f, z * 277.7777778f);
    public static ForceAccel3 MeganewtonsPerHour(Vector3 v) => new(v.x * 277.7777778f, v.y * 277.7777778f, v.z * 277.7777778f);

    public static ForceAccel3 operator +(ForceAccel3 a, ForceAccel3 b) => new(a.x + b.x, a.y + b.y, a.z + b.z);
    public static ForceAccel3 operator -(ForceAccel3 a, ForceAccel3 b) => new(a.x - b.x, a.y - b.y, a.z - b.z);
    
    public static ForceAccel3 operator *(ForceAccel3 a, ForceAccel3 b) => new(a.x * b.x, a.y * b.y, a.z * b.z);
    public static ForceAccel3 operator /(ForceAccel3 a, ForceAccel3 b) => new(a.x / b.x, a.y / b.y, a.z / b.z);
    
    public Force3 Force3(Time v) => new(v * x, v * y, v * z);
    public Time Time(Force3 v) => new(v.magnitude / magnitude);

    public ForceAccel3(Force3 a, Time b) : this(a.ForceAccel3(b)) { }
    public ForceAccel3(Time b, Force3 a) : this(a.ForceAccel3(b)) { }

}
}

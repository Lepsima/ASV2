using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Direction2 : IAutoUnit2 {
    public float x, y;
    
    public Direction2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Direction2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;
    public static implicit operator Vector2(Direction2 v) => new(v.x, v.y);

    public Direction2 normalized => new(vector.normalized);
    public Magnitude sqrMagnitude => new(vector.sqrMagnitude);
    public Magnitude magnitude => new(vector.magnitude);

    public static Position2 operator *(Position left, Direction2 right) => new(left.vector * right.vector);
    public static Position2 operator *(Direction2 left, Position right) => new(left.vector * right.vector);

    public static Velocity2 operator *(Velocity left, Direction2 right) => new(left.vector * right.vector);
    public static Velocity2 operator *(Direction2 left, Velocity right) => new(left.vector * right.vector);

    public static Accel2 operator *(Accel left, Direction2 right) => new(left.vector * right.vector);
    public static Accel2 operator *(Direction2 left, Accel right) => new(left.vector * right.vector);

    public static Force2 operator *(Force left, Direction2 right) => new(left.vector * right.vector);
    public static Force2 operator *(Direction2 left, Force right) => new(left.vector * right.vector);

    public static ForceAccel2 operator *(ForceAccel left, Direction2 right) => new(left.vector * right.vector);
    public static ForceAccel2 operator *(Direction2 left, ForceAccel right) => new(left.vector * right.vector);

    public static Angle2 operator *(Angle left, Direction2 right) => new(left.vector * right.vector);
    public static Angle2 operator *(Direction2 left, Angle right) => new(left.vector * right.vector);

    public static AngleVel2 operator *(AngleVel left, Direction2 right) => new(left.vector * right.vector);
    public static AngleVel2 operator *(Direction2 left, AngleVel right) => new(left.vector * right.vector);

    public static AngleAccel2 operator *(AngleAccel left, Direction2 right) => new(left.vector * right.vector);
    public static AngleAccel2 operator *(Direction2 left, AngleAccel right) => new(left.vector * right.vector);

    public static Torque2 operator *(Torque left, Direction2 right) => new(left.vector * right.vector);
    public static Torque2 operator *(Direction2 left, Torque right) => new(left.vector * right.vector);

    public static TorqueAccel2 operator *(TorqueAccel left, Direction2 right) => new(left.vector * right.vector);
    public static TorqueAccel2 operator *(Direction2 left, TorqueAccel right) => new(left.vector * right.vector);

    public Vector2 ToNormal() => new(x * 1f, y * 1f);
    public static Direction2 Normal(float x, float y) => new(x * 1f, y * 1f);
    public static Direction2 Normal(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToDir() => new(x * 1f, y * 1f);
    public static Direction2 Dir(float x, float y) => new(x * 1f, y * 1f);
    public static Direction2 Dir(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public static Direction2 operator +(Direction2 a, Direction2 b) => new(a.x + b.x, a.y + b.y);
    public static Direction2 operator -(Direction2 a, Direction2 b) => new(a.x - b.x, a.y - b.y);
    
    public static Direction2 operator *(Direction2 a, Direction2 b) => new(a.x * b.x, a.y * b.y);
    public static Direction2 operator /(Direction2 a, Direction2 b) => new(a.x / b.x, a.y / b.y);
    
}
}

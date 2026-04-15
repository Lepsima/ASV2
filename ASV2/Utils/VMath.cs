using UnityEngine;

namespace Lepsima.ASV {
public static class VMath {
	public static Force Clamp(Force force, float min, float	max) => new(Mathf.Clamp(force.vector, min, max));
	
	public static Angle AngleBetween(Direction2 a, Direction2 b) => Angle.Degree(Vector2.Angle(a.vector, b.vector));
	public static Angle AngleBetween(Direction3 a, Direction3 b) => Angle.Degree(Vector3.Angle(a.vector, b.vector));
	
	public static Force3 Drag(Velocity3 velocity, Magnitude drag) {
		Force dragForce = Force.Newton(velocity.sqrMagnitude * drag * -0.5f);
		Direction3 dir = velocity.normalized;
		return dir * dragForce;
	}
	
	public static Accel3 Drag(this Mass mass, Velocity3 velocity, Magnitude drag) {
		return new Accel3(Drag(velocity, drag), mass);
	}
}
}
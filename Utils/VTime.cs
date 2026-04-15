namespace Lepsima.ASV {
public static class VTime {
	public static Time deltaTime => Time.Second(UnityEngine.Time.deltaTime);
	public static Time time => Time.Second(UnityEngine.Time.time);
}
}
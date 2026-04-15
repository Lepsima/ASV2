using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct Accel2 : IAutoUnit2 {
    public float x, y;
    
    public Accel2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public Accel2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;
    public static implicit operator Vector2(Accel2 v) => new(v.x, v.y);

    public Direction2 normalized => new(vector.normalized);
    public Accel sqrMagnitude => new(vector.sqrMagnitude);
    public Accel magnitude => new(vector.magnitude);

    public Vector2 ToFeetsPerMicrosecond2() => new(x * 3.048E-13f, y * 3.048E-13f);
    public static Accel2 FeetsPerMicrosecond2(float x, float y) => new(x * 3.280839895E+12f, y * 3.280839895E+12f);
    public static Accel2 FeetsPerMicrosecond2(Vector2 v) => new(v.x * 3.280839895E+12f, v.y * 3.280839895E+12f);

    public Vector2 ToFeetsPerMicrosecondsPerMillisecond() => new(x * 3.048E-10f, y * 3.048E-10f);
    public static Accel2 FeetsPerMicrosecondsPerMillisecond(float x, float y) => new(x * 3280839895f, y * 3280839895f);
    public static Accel2 FeetsPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 3280839895f, v.y * 3280839895f);

    public Vector2 ToFeetsPerMicrosecondsPerSecond() => new(x * 3.048E-07f, y * 3.048E-07f);
    public static Accel2 FeetsPerMicrosecondsPerSecond(float x, float y) => new(x * 3280839.895f, y * 3280839.895f);
    public static Accel2 FeetsPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 3280839.895f, v.y * 3280839.895f);

    public Vector2 ToFeetsPerMicrosecondsPerMinute() => new(x * 1.8288E-05f, y * 1.8288E-05f);
    public static Accel2 FeetsPerMicrosecondsPerMinute(float x, float y) => new(x * 54680.66492f, y * 54680.66492f);
    public static Accel2 FeetsPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 54680.66492f, v.y * 54680.66492f);

    public Vector2 ToFeetsPerMicrosecondsPerHour() => new(x * 0.00109728f, y * 0.00109728f);
    public static Accel2 FeetsPerMicrosecondsPerHour(float x, float y) => new(x * 911.3444153f, y * 911.3444153f);
    public static Accel2 FeetsPerMicrosecondsPerHour(Vector2 v) => new(v.x * 911.3444153f, v.y * 911.3444153f);

    public Vector2 ToFeetsPerMillisecondsPerMicrosecond() => new(x * 3.048E-10f, y * 3.048E-10f);
    public static Accel2 FeetsPerMillisecondsPerMicrosecond(float x, float y) => new(x * 3280839895f, y * 3280839895f);
    public static Accel2 FeetsPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 3280839895f, v.y * 3280839895f);

    public Vector2 ToFeetsPerMillisecond2() => new(x * 3.048E-07f, y * 3.048E-07f);
    public static Accel2 FeetsPerMillisecond2(float x, float y) => new(x * 3280839.895f, y * 3280839.895f);
    public static Accel2 FeetsPerMillisecond2(Vector2 v) => new(v.x * 3280839.895f, v.y * 3280839.895f);

    public Vector2 ToFeetsPerMillisecondsPerSecond() => new(x * 0.0003048f, y * 0.0003048f);
    public static Accel2 FeetsPerMillisecondsPerSecond(float x, float y) => new(x * 3280.839895f, y * 3280.839895f);
    public static Accel2 FeetsPerMillisecondsPerSecond(Vector2 v) => new(v.x * 3280.839895f, v.y * 3280.839895f);

    public Vector2 ToFeetsPerMillisecondsPerMinute() => new(x * 0.018288f, y * 0.018288f);
    public static Accel2 FeetsPerMillisecondsPerMinute(float x, float y) => new(x * 54.68066492f, y * 54.68066492f);
    public static Accel2 FeetsPerMillisecondsPerMinute(Vector2 v) => new(v.x * 54.68066492f, v.y * 54.68066492f);

    public Vector2 ToFeetsPerMillisecondsPerHour() => new(x * 1.09728f, y * 1.09728f);
    public static Accel2 FeetsPerMillisecondsPerHour(float x, float y) => new(x * 0.9113444153f, y * 0.9113444153f);
    public static Accel2 FeetsPerMillisecondsPerHour(Vector2 v) => new(v.x * 0.9113444153f, v.y * 0.9113444153f);

    public Vector2 ToFeetsPerSecondsPerMicrosecond() => new(x * 3.048E-07f, y * 3.048E-07f);
    public static Accel2 FeetsPerSecondsPerMicrosecond(float x, float y) => new(x * 3280839.895f, y * 3280839.895f);
    public static Accel2 FeetsPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 3280839.895f, v.y * 3280839.895f);

    public Vector2 ToFeetsPerSecondsPerMillisecond() => new(x * 0.0003048f, y * 0.0003048f);
    public static Accel2 FeetsPerSecondsPerMillisecond(float x, float y) => new(x * 3280.839895f, y * 3280.839895f);
    public static Accel2 FeetsPerSecondsPerMillisecond(Vector2 v) => new(v.x * 3280.839895f, v.y * 3280.839895f);

    public Vector2 ToFeetsPerSecond2() => new(x * 0.3048f, y * 0.3048f);
    public static Accel2 FeetsPerSecond2(float x, float y) => new(x * 3.280839895f, y * 3.280839895f);
    public static Accel2 FeetsPerSecond2(Vector2 v) => new(v.x * 3.280839895f, v.y * 3.280839895f);

    public Vector2 ToFeetsPerSecondsPerMinute() => new(x * 18.288f, y * 18.288f);
    public static Accel2 FeetsPerSecondsPerMinute(float x, float y) => new(x * 0.05468066492f, y * 0.05468066492f);
    public static Accel2 FeetsPerSecondsPerMinute(Vector2 v) => new(v.x * 0.05468066492f, v.y * 0.05468066492f);

    public Vector2 ToFeetsPerSecondsPerHour() => new(x * 1097.28f, y * 1097.28f);
    public static Accel2 FeetsPerSecondsPerHour(float x, float y) => new(x * 0.0009113444153f, y * 0.0009113444153f);
    public static Accel2 FeetsPerSecondsPerHour(Vector2 v) => new(v.x * 0.0009113444153f, v.y * 0.0009113444153f);

    public Vector2 ToFeetsPerMinutesPerMicrosecond() => new(x * 1.8288E-05f, y * 1.8288E-05f);
    public static Accel2 FeetsPerMinutesPerMicrosecond(float x, float y) => new(x * 54680.66492f, y * 54680.66492f);
    public static Accel2 FeetsPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 54680.66492f, v.y * 54680.66492f);

    public Vector2 ToFeetsPerMinutesPerMillisecond() => new(x * 0.018288f, y * 0.018288f);
    public static Accel2 FeetsPerMinutesPerMillisecond(float x, float y) => new(x * 54.68066492f, y * 54.68066492f);
    public static Accel2 FeetsPerMinutesPerMillisecond(Vector2 v) => new(v.x * 54.68066492f, v.y * 54.68066492f);

    public Vector2 ToFeetsPerMinutesPerSecond() => new(x * 18.288f, y * 18.288f);
    public static Accel2 FeetsPerMinutesPerSecond(float x, float y) => new(x * 0.05468066492f, y * 0.05468066492f);
    public static Accel2 FeetsPerMinutesPerSecond(Vector2 v) => new(v.x * 0.05468066492f, v.y * 0.05468066492f);

    public Vector2 ToFeetsPerMinute2() => new(x * 1097.28f, y * 1097.28f);
    public static Accel2 FeetsPerMinute2(float x, float y) => new(x * 0.0009113444153f, y * 0.0009113444153f);
    public static Accel2 FeetsPerMinute2(Vector2 v) => new(v.x * 0.0009113444153f, v.y * 0.0009113444153f);

    public Vector2 ToFeetsPerMinutesPerHour() => new(x * 65836.8f, y * 65836.8f);
    public static Accel2 FeetsPerMinutesPerHour(float x, float y) => new(x * 1.518907359E-05f, y * 1.518907359E-05f);
    public static Accel2 FeetsPerMinutesPerHour(Vector2 v) => new(v.x * 1.518907359E-05f, v.y * 1.518907359E-05f);

    public Vector2 ToFeetsPerHoursPerMicrosecond() => new(x * 0.00109728f, y * 0.00109728f);
    public static Accel2 FeetsPerHoursPerMicrosecond(float x, float y) => new(x * 911.3444153f, y * 911.3444153f);
    public static Accel2 FeetsPerHoursPerMicrosecond(Vector2 v) => new(v.x * 911.3444153f, v.y * 911.3444153f);

    public Vector2 ToFeetsPerHoursPerMillisecond() => new(x * 1.09728f, y * 1.09728f);
    public static Accel2 FeetsPerHoursPerMillisecond(float x, float y) => new(x * 0.9113444153f, y * 0.9113444153f);
    public static Accel2 FeetsPerHoursPerMillisecond(Vector2 v) => new(v.x * 0.9113444153f, v.y * 0.9113444153f);

    public Vector2 ToFeetsPerHoursPerSecond() => new(x * 1097.28f, y * 1097.28f);
    public static Accel2 FeetsPerHoursPerSecond(float x, float y) => new(x * 0.0009113444153f, y * 0.0009113444153f);
    public static Accel2 FeetsPerHoursPerSecond(Vector2 v) => new(v.x * 0.0009113444153f, v.y * 0.0009113444153f);

    public Vector2 ToFeetsPerHoursPerMinute() => new(x * 65836.8f, y * 65836.8f);
    public static Accel2 FeetsPerHoursPerMinute(float x, float y) => new(x * 1.518907359E-05f, y * 1.518907359E-05f);
    public static Accel2 FeetsPerHoursPerMinute(Vector2 v) => new(v.x * 1.518907359E-05f, v.y * 1.518907359E-05f);

    public Vector2 ToFeetsPerHour2() => new(x * 3950208f, y * 3950208f);
    public static Accel2 FeetsPerHour2(float x, float y) => new(x * 2.531512265E-07f, y * 2.531512265E-07f);
    public static Accel2 FeetsPerHour2(Vector2 v) => new(v.x * 2.531512265E-07f, v.y * 2.531512265E-07f);

    public Vector2 ToMilesPerMicrosecond2() => new(x * 6.213711922E-16f, y * 6.213711922E-16f);
    public static Accel2 MilesPerMicrosecond2(float x, float y) => new(x * 1.609344E+15f, y * 1.609344E+15f);
    public static Accel2 MilesPerMicrosecond2(Vector2 v) => new(v.x * 1.609344E+15f, v.y * 1.609344E+15f);

    public Vector2 ToMilesPerMicrosecondsPerMillisecond() => new(x * 6.213711922E-13f, y * 6.213711922E-13f);
    public static Accel2 MilesPerMicrosecondsPerMillisecond(float x, float y) => new(x * 1.609344E+12f, y * 1.609344E+12f);
    public static Accel2 MilesPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 1.609344E+12f, v.y * 1.609344E+12f);

    public Vector2 ToMilesPerMicrosecondsPerSecond() => new(x * 6.213711922E-10f, y * 6.213711922E-10f);
    public static Accel2 MilesPerMicrosecondsPerSecond(float x, float y) => new(x * 1609344000f, y * 1609344000f);
    public static Accel2 MilesPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 1609344000f, v.y * 1609344000f);

    public Vector2 ToMilesPerMicrosecondsPerMinute() => new(x * 3.728227153E-08f, y * 3.728227153E-08f);
    public static Accel2 MilesPerMicrosecondsPerMinute(float x, float y) => new(x * 26822400f, y * 26822400f);
    public static Accel2 MilesPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 26822400f, v.y * 26822400f);

    public Vector2 ToMilesPerMicrosecondsPerHour() => new(x * 2.236936292E-06f, y * 2.236936292E-06f);
    public static Accel2 MilesPerMicrosecondsPerHour(float x, float y) => new(x * 447040f, y * 447040f);
    public static Accel2 MilesPerMicrosecondsPerHour(Vector2 v) => new(v.x * 447040f, v.y * 447040f);

    public Vector2 ToMilesPerMillisecondsPerMicrosecond() => new(x * 6.213711922E-13f, y * 6.213711922E-13f);
    public static Accel2 MilesPerMillisecondsPerMicrosecond(float x, float y) => new(x * 1.609344E+12f, y * 1.609344E+12f);
    public static Accel2 MilesPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 1.609344E+12f, v.y * 1.609344E+12f);

    public Vector2 ToMilesPerMillisecond2() => new(x * 6.213711922E-10f, y * 6.213711922E-10f);
    public static Accel2 MilesPerMillisecond2(float x, float y) => new(x * 1609344000f, y * 1609344000f);
    public static Accel2 MilesPerMillisecond2(Vector2 v) => new(v.x * 1609344000f, v.y * 1609344000f);

    public Vector2 ToMilesPerMillisecondsPerSecond() => new(x * 6.213711922E-07f, y * 6.213711922E-07f);
    public static Accel2 MilesPerMillisecondsPerSecond(float x, float y) => new(x * 1609344f, y * 1609344f);
    public static Accel2 MilesPerMillisecondsPerSecond(Vector2 v) => new(v.x * 1609344f, v.y * 1609344f);

    public Vector2 ToMilesPerMillisecondsPerMinute() => new(x * 3.728227153E-05f, y * 3.728227153E-05f);
    public static Accel2 MilesPerMillisecondsPerMinute(float x, float y) => new(x * 26822.4f, y * 26822.4f);
    public static Accel2 MilesPerMillisecondsPerMinute(Vector2 v) => new(v.x * 26822.4f, v.y * 26822.4f);

    public Vector2 ToMilesPerMillisecondsPerHour() => new(x * 0.002236936292f, y * 0.002236936292f);
    public static Accel2 MilesPerMillisecondsPerHour(float x, float y) => new(x * 447.04f, y * 447.04f);
    public static Accel2 MilesPerMillisecondsPerHour(Vector2 v) => new(v.x * 447.04f, v.y * 447.04f);

    public Vector2 ToMilesPerSecondsPerMicrosecond() => new(x * 6.213711922E-10f, y * 6.213711922E-10f);
    public static Accel2 MilesPerSecondsPerMicrosecond(float x, float y) => new(x * 1609344000f, y * 1609344000f);
    public static Accel2 MilesPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 1609344000f, v.y * 1609344000f);

    public Vector2 ToMilesPerSecondsPerMillisecond() => new(x * 6.213711922E-07f, y * 6.213711922E-07f);
    public static Accel2 MilesPerSecondsPerMillisecond(float x, float y) => new(x * 1609344f, y * 1609344f);
    public static Accel2 MilesPerSecondsPerMillisecond(Vector2 v) => new(v.x * 1609344f, v.y * 1609344f);

    public Vector2 ToMilesPerSecond2() => new(x * 0.0006213711922f, y * 0.0006213711922f);
    public static Accel2 MilesPerSecond2(float x, float y) => new(x * 1609.344f, y * 1609.344f);
    public static Accel2 MilesPerSecond2(Vector2 v) => new(v.x * 1609.344f, v.y * 1609.344f);

    public Vector2 ToMilesPerSecondsPerMinute() => new(x * 0.03728227153f, y * 0.03728227153f);
    public static Accel2 MilesPerSecondsPerMinute(float x, float y) => new(x * 26.8224f, y * 26.8224f);
    public static Accel2 MilesPerSecondsPerMinute(Vector2 v) => new(v.x * 26.8224f, v.y * 26.8224f);

    public Vector2 ToMilesPerSecondsPerHour() => new(x * 2.236936292f, y * 2.236936292f);
    public static Accel2 MilesPerSecondsPerHour(float x, float y) => new(x * 0.44704f, y * 0.44704f);
    public static Accel2 MilesPerSecondsPerHour(Vector2 v) => new(v.x * 0.44704f, v.y * 0.44704f);

    public Vector2 ToMilesPerMinutesPerMicrosecond() => new(x * 3.728227153E-08f, y * 3.728227153E-08f);
    public static Accel2 MilesPerMinutesPerMicrosecond(float x, float y) => new(x * 26822400f, y * 26822400f);
    public static Accel2 MilesPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 26822400f, v.y * 26822400f);

    public Vector2 ToMilesPerMinutesPerMillisecond() => new(x * 3.728227153E-05f, y * 3.728227153E-05f);
    public static Accel2 MilesPerMinutesPerMillisecond(float x, float y) => new(x * 26822.4f, y * 26822.4f);
    public static Accel2 MilesPerMinutesPerMillisecond(Vector2 v) => new(v.x * 26822.4f, v.y * 26822.4f);

    public Vector2 ToMilesPerMinutesPerSecond() => new(x * 0.03728227153f, y * 0.03728227153f);
    public static Accel2 MilesPerMinutesPerSecond(float x, float y) => new(x * 26.8224f, y * 26.8224f);
    public static Accel2 MilesPerMinutesPerSecond(Vector2 v) => new(v.x * 26.8224f, v.y * 26.8224f);

    public Vector2 ToMilesPerMinute2() => new(x * 2.236936292f, y * 2.236936292f);
    public static Accel2 MilesPerMinute2(float x, float y) => new(x * 0.44704f, y * 0.44704f);
    public static Accel2 MilesPerMinute2(Vector2 v) => new(v.x * 0.44704f, v.y * 0.44704f);

    public Vector2 ToMilesPerMinutesPerHour() => new(x * 134.2161775f, y * 134.2161775f);
    public static Accel2 MilesPerMinutesPerHour(float x, float y) => new(x * 0.007450666667f, y * 0.007450666667f);
    public static Accel2 MilesPerMinutesPerHour(Vector2 v) => new(v.x * 0.007450666667f, v.y * 0.007450666667f);

    public Vector2 ToMilesPerHoursPerMicrosecond() => new(x * 2.236936292E-06f, y * 2.236936292E-06f);
    public static Accel2 MilesPerHoursPerMicrosecond(float x, float y) => new(x * 447040f, y * 447040f);
    public static Accel2 MilesPerHoursPerMicrosecond(Vector2 v) => new(v.x * 447040f, v.y * 447040f);

    public Vector2 ToMilesPerHoursPerMillisecond() => new(x * 0.002236936292f, y * 0.002236936292f);
    public static Accel2 MilesPerHoursPerMillisecond(float x, float y) => new(x * 447.04f, y * 447.04f);
    public static Accel2 MilesPerHoursPerMillisecond(Vector2 v) => new(v.x * 447.04f, v.y * 447.04f);

    public Vector2 ToMilesPerHoursPerSecond() => new(x * 2.236936292f, y * 2.236936292f);
    public static Accel2 MilesPerHoursPerSecond(float x, float y) => new(x * 0.44704f, y * 0.44704f);
    public static Accel2 MilesPerHoursPerSecond(Vector2 v) => new(v.x * 0.44704f, v.y * 0.44704f);

    public Vector2 ToMilesPerHoursPerMinute() => new(x * 134.2161775f, y * 134.2161775f);
    public static Accel2 MilesPerHoursPerMinute(float x, float y) => new(x * 0.007450666667f, y * 0.007450666667f);
    public static Accel2 MilesPerHoursPerMinute(Vector2 v) => new(v.x * 0.007450666667f, v.y * 0.007450666667f);

    public Vector2 ToMilesPerHour2() => new(x * 8052.970651f, y * 8052.970651f);
    public static Accel2 MilesPerHour2(float x, float y) => new(x * 0.0001241777778f, y * 0.0001241777778f);
    public static Accel2 MilesPerHour2(Vector2 v) => new(v.x * 0.0001241777778f, v.y * 0.0001241777778f);

    public Vector2 ToMillimetersPerMicrosecond2() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 MillimetersPerMicrosecond2(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 MillimetersPerMicrosecond2(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMillimetersPerMicrosecondsPerMillisecond() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 MillimetersPerMicrosecondsPerMillisecond(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 MillimetersPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMillimetersPerMicrosecondsPerSecond() => new(x * 0.001f, y * 0.001f);
    public static Accel2 MillimetersPerMicrosecondsPerSecond(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 MillimetersPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillimetersPerMicrosecondsPerMinute() => new(x * 0.06f, y * 0.06f);
    public static Accel2 MillimetersPerMicrosecondsPerMinute(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static Accel2 MillimetersPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMillimetersPerMicrosecondsPerHour() => new(x * 3.6f, y * 3.6f);
    public static Accel2 MillimetersPerMicrosecondsPerHour(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static Accel2 MillimetersPerMicrosecondsPerHour(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMillimetersPerMillisecondsPerMicrosecond() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 MillimetersPerMillisecondsPerMicrosecond(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 MillimetersPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMillimetersPerMillisecond2() => new(x * 0.001f, y * 0.001f);
    public static Accel2 MillimetersPerMillisecond2(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 MillimetersPerMillisecond2(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillimetersPerMillisecondsPerSecond() => new(x * 1f, y * 1f);
    public static Accel2 MillimetersPerMillisecondsPerSecond(float x, float y) => new(x * 1f, y * 1f);
    public static Accel2 MillimetersPerMillisecondsPerSecond(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToMillimetersPerMillisecondsPerMinute() => new(x * 60f, y * 60f);
    public static Accel2 MillimetersPerMillisecondsPerMinute(float x, float y) => new(x * 0.01666666667f, y * 0.01666666667f);
    public static Accel2 MillimetersPerMillisecondsPerMinute(Vector2 v) => new(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMillimetersPerMillisecondsPerHour() => new(x * 3600f, y * 3600f);
    public static Accel2 MillimetersPerMillisecondsPerHour(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Accel2 MillimetersPerMillisecondsPerHour(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMillimetersPerSecondsPerMicrosecond() => new(x * 0.001f, y * 0.001f);
    public static Accel2 MillimetersPerSecondsPerMicrosecond(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 MillimetersPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMillimetersPerSecondsPerMillisecond() => new(x * 1f, y * 1f);
    public static Accel2 MillimetersPerSecondsPerMillisecond(float x, float y) => new(x * 1f, y * 1f);
    public static Accel2 MillimetersPerSecondsPerMillisecond(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToMillimetersPerSecond2() => new(x * 1000f, y * 1000f);
    public static Accel2 MillimetersPerSecond2(float x, float y) => new(x * 0.001f, y * 0.001f);
    public static Accel2 MillimetersPerSecond2(Vector2 v) => new(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillimetersPerSecondsPerMinute() => new(x * 60000f, y * 60000f);
    public static Accel2 MillimetersPerSecondsPerMinute(float x, float y) => new(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static Accel2 MillimetersPerSecondsPerMinute(Vector2 v) => new(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToMillimetersPerSecondsPerHour() => new(x * 3600000f, y * 3600000f);
    public static Accel2 MillimetersPerSecondsPerHour(float x, float y) => new(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static Accel2 MillimetersPerSecondsPerHour(Vector2 v) => new(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToMillimetersPerMinutesPerMicrosecond() => new(x * 0.06f, y * 0.06f);
    public static Accel2 MillimetersPerMinutesPerMicrosecond(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static Accel2 MillimetersPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMillimetersPerMinutesPerMillisecond() => new(x * 60f, y * 60f);
    public static Accel2 MillimetersPerMinutesPerMillisecond(float x, float y) => new(x * 0.01666666667f, y * 0.01666666667f);
    public static Accel2 MillimetersPerMinutesPerMillisecond(Vector2 v) => new(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMillimetersPerMinutesPerSecond() => new(x * 60000f, y * 60000f);
    public static Accel2 MillimetersPerMinutesPerSecond(float x, float y) => new(x * 1.666666667E-05f, y * 1.666666667E-05f);
    public static Accel2 MillimetersPerMinutesPerSecond(Vector2 v) => new(v.x * 1.666666667E-05f, v.y * 1.666666667E-05f);

    public Vector2 ToMillimetersPerMinute2() => new(x * 3600000f, y * 3600000f);
    public static Accel2 MillimetersPerMinute2(float x, float y) => new(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static Accel2 MillimetersPerMinute2(Vector2 v) => new(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToMillimetersPerMinutesPerHour() => new(x * 216000000f, y * 216000000f);
    public static Accel2 MillimetersPerMinutesPerHour(float x, float y) => new(x * 4.62962963E-09f, y * 4.62962963E-09f);
    public static Accel2 MillimetersPerMinutesPerHour(Vector2 v) => new(v.x * 4.62962963E-09f, v.y * 4.62962963E-09f);

    public Vector2 ToMillimetersPerHoursPerMicrosecond() => new(x * 3.6f, y * 3.6f);
    public static Accel2 MillimetersPerHoursPerMicrosecond(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static Accel2 MillimetersPerHoursPerMicrosecond(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMillimetersPerHoursPerMillisecond() => new(x * 3600f, y * 3600f);
    public static Accel2 MillimetersPerHoursPerMillisecond(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Accel2 MillimetersPerHoursPerMillisecond(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMillimetersPerHoursPerSecond() => new(x * 3600000f, y * 3600000f);
    public static Accel2 MillimetersPerHoursPerSecond(float x, float y) => new(x * 2.777777778E-07f, y * 2.777777778E-07f);
    public static Accel2 MillimetersPerHoursPerSecond(Vector2 v) => new(v.x * 2.777777778E-07f, v.y * 2.777777778E-07f);

    public Vector2 ToMillimetersPerHoursPerMinute() => new(x * 216000000f, y * 216000000f);
    public static Accel2 MillimetersPerHoursPerMinute(float x, float y) => new(x * 4.62962963E-09f, y * 4.62962963E-09f);
    public static Accel2 MillimetersPerHoursPerMinute(Vector2 v) => new(v.x * 4.62962963E-09f, v.y * 4.62962963E-09f);

    public Vector2 ToMillimetersPerHour2() => new(x * 1.296E+10f, y * 1.296E+10f);
    public static Accel2 MillimetersPerHour2(float x, float y) => new(x * 7.716049383E-11f, y * 7.716049383E-11f);
    public static Accel2 MillimetersPerHour2(Vector2 v) => new(v.x * 7.716049383E-11f, v.y * 7.716049383E-11f);

    public Vector2 ToCentimetersPerMicrosecond2() => new(x * 1E-10f, y * 1E-10f);
    public static Accel2 CentimetersPerMicrosecond2(float x, float y) => new(x * 1E+10f, y * 1E+10f);
    public static Accel2 CentimetersPerMicrosecond2(Vector2 v) => new(v.x * 1E+10f, v.y * 1E+10f);

    public Vector2 ToCentimetersPerMicrosecondsPerMillisecond() => new(x * 1E-07f, y * 1E-07f);
    public static Accel2 CentimetersPerMicrosecondsPerMillisecond(float x, float y) => new(x * 10000000f, y * 10000000f);
    public static Accel2 CentimetersPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 10000000f, v.y * 10000000f);

    public Vector2 ToCentimetersPerMicrosecondsPerSecond() => new(x * 0.0001f, y * 0.0001f);
    public static Accel2 CentimetersPerMicrosecondsPerSecond(float x, float y) => new(x * 10000f, y * 10000f);
    public static Accel2 CentimetersPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 10000f, v.y * 10000f);

    public Vector2 ToCentimetersPerMicrosecondsPerMinute() => new(x * 0.006f, y * 0.006f);
    public static Accel2 CentimetersPerMicrosecondsPerMinute(float x, float y) => new(x * 166.6666667f, y * 166.6666667f);
    public static Accel2 CentimetersPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 166.6666667f, v.y * 166.6666667f);

    public Vector2 ToCentimetersPerMicrosecondsPerHour() => new(x * 0.36f, y * 0.36f);
    public static Accel2 CentimetersPerMicrosecondsPerHour(float x, float y) => new(x * 2.777777778f, y * 2.777777778f);
    public static Accel2 CentimetersPerMicrosecondsPerHour(Vector2 v) => new(v.x * 2.777777778f, v.y * 2.777777778f);

    public Vector2 ToCentimetersPerMillisecondsPerMicrosecond() => new(x * 1E-07f, y * 1E-07f);
    public static Accel2 CentimetersPerMillisecondsPerMicrosecond(float x, float y) => new(x * 10000000f, y * 10000000f);
    public static Accel2 CentimetersPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 10000000f, v.y * 10000000f);

    public Vector2 ToCentimetersPerMillisecond2() => new(x * 0.0001f, y * 0.0001f);
    public static Accel2 CentimetersPerMillisecond2(float x, float y) => new(x * 10000f, y * 10000f);
    public static Accel2 CentimetersPerMillisecond2(Vector2 v) => new(v.x * 10000f, v.y * 10000f);

    public Vector2 ToCentimetersPerMillisecondsPerSecond() => new(x * 0.1f, y * 0.1f);
    public static Accel2 CentimetersPerMillisecondsPerSecond(float x, float y) => new(x * 10f, y * 10f);
    public static Accel2 CentimetersPerMillisecondsPerSecond(Vector2 v) => new(v.x * 10f, v.y * 10f);

    public Vector2 ToCentimetersPerMillisecondsPerMinute() => new(x * 6f, y * 6f);
    public static Accel2 CentimetersPerMillisecondsPerMinute(float x, float y) => new(x * 0.1666666667f, y * 0.1666666667f);
    public static Accel2 CentimetersPerMillisecondsPerMinute(Vector2 v) => new(v.x * 0.1666666667f, v.y * 0.1666666667f);

    public Vector2 ToCentimetersPerMillisecondsPerHour() => new(x * 360f, y * 360f);
    public static Accel2 CentimetersPerMillisecondsPerHour(float x, float y) => new(x * 0.002777777778f, y * 0.002777777778f);
    public static Accel2 CentimetersPerMillisecondsPerHour(Vector2 v) => new(v.x * 0.002777777778f, v.y * 0.002777777778f);

    public Vector2 ToCentimetersPerSecondsPerMicrosecond() => new(x * 0.0001f, y * 0.0001f);
    public static Accel2 CentimetersPerSecondsPerMicrosecond(float x, float y) => new(x * 10000f, y * 10000f);
    public static Accel2 CentimetersPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 10000f, v.y * 10000f);

    public Vector2 ToCentimetersPerSecondsPerMillisecond() => new(x * 0.1f, y * 0.1f);
    public static Accel2 CentimetersPerSecondsPerMillisecond(float x, float y) => new(x * 10f, y * 10f);
    public static Accel2 CentimetersPerSecondsPerMillisecond(Vector2 v) => new(v.x * 10f, v.y * 10f);

    public Vector2 ToCentimetersPerSecond2() => new(x * 100f, y * 100f);
    public static Accel2 CentimetersPerSecond2(float x, float y) => new(x * 0.01f, y * 0.01f);
    public static Accel2 CentimetersPerSecond2(Vector2 v) => new(v.x * 0.01f, v.y * 0.01f);

    public Vector2 ToCentimetersPerSecondsPerMinute() => new(x * 6000f, y * 6000f);
    public static Accel2 CentimetersPerSecondsPerMinute(float x, float y) => new(x * 0.0001666666667f, y * 0.0001666666667f);
    public static Accel2 CentimetersPerSecondsPerMinute(Vector2 v) => new(v.x * 0.0001666666667f, v.y * 0.0001666666667f);

    public Vector2 ToCentimetersPerSecondsPerHour() => new(x * 360000f, y * 360000f);
    public static Accel2 CentimetersPerSecondsPerHour(float x, float y) => new(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static Accel2 CentimetersPerSecondsPerHour(Vector2 v) => new(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f);

    public Vector2 ToCentimetersPerMinutesPerMicrosecond() => new(x * 0.006f, y * 0.006f);
    public static Accel2 CentimetersPerMinutesPerMicrosecond(float x, float y) => new(x * 166.6666667f, y * 166.6666667f);
    public static Accel2 CentimetersPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 166.6666667f, v.y * 166.6666667f);

    public Vector2 ToCentimetersPerMinutesPerMillisecond() => new(x * 6f, y * 6f);
    public static Accel2 CentimetersPerMinutesPerMillisecond(float x, float y) => new(x * 0.1666666667f, y * 0.1666666667f);
    public static Accel2 CentimetersPerMinutesPerMillisecond(Vector2 v) => new(v.x * 0.1666666667f, v.y * 0.1666666667f);

    public Vector2 ToCentimetersPerMinutesPerSecond() => new(x * 6000f, y * 6000f);
    public static Accel2 CentimetersPerMinutesPerSecond(float x, float y) => new(x * 0.0001666666667f, y * 0.0001666666667f);
    public static Accel2 CentimetersPerMinutesPerSecond(Vector2 v) => new(v.x * 0.0001666666667f, v.y * 0.0001666666667f);

    public Vector2 ToCentimetersPerMinute2() => new(x * 360000f, y * 360000f);
    public static Accel2 CentimetersPerMinute2(float x, float y) => new(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static Accel2 CentimetersPerMinute2(Vector2 v) => new(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f);

    public Vector2 ToCentimetersPerMinutesPerHour() => new(x * 21600000f, y * 21600000f);
    public static Accel2 CentimetersPerMinutesPerHour(float x, float y) => new(x * 4.62962963E-08f, y * 4.62962963E-08f);
    public static Accel2 CentimetersPerMinutesPerHour(Vector2 v) => new(v.x * 4.62962963E-08f, v.y * 4.62962963E-08f);

    public Vector2 ToCentimetersPerHoursPerMicrosecond() => new(x * 0.36f, y * 0.36f);
    public static Accel2 CentimetersPerHoursPerMicrosecond(float x, float y) => new(x * 2.777777778f, y * 2.777777778f);
    public static Accel2 CentimetersPerHoursPerMicrosecond(Vector2 v) => new(v.x * 2.777777778f, v.y * 2.777777778f);

    public Vector2 ToCentimetersPerHoursPerMillisecond() => new(x * 360f, y * 360f);
    public static Accel2 CentimetersPerHoursPerMillisecond(float x, float y) => new(x * 0.002777777778f, y * 0.002777777778f);
    public static Accel2 CentimetersPerHoursPerMillisecond(Vector2 v) => new(v.x * 0.002777777778f, v.y * 0.002777777778f);

    public Vector2 ToCentimetersPerHoursPerSecond() => new(x * 360000f, y * 360000f);
    public static Accel2 CentimetersPerHoursPerSecond(float x, float y) => new(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static Accel2 CentimetersPerHoursPerSecond(Vector2 v) => new(v.x * 2.777777778E-06f, v.y * 2.777777778E-06f);

    public Vector2 ToCentimetersPerHoursPerMinute() => new(x * 21600000f, y * 21600000f);
    public static Accel2 CentimetersPerHoursPerMinute(float x, float y) => new(x * 4.62962963E-08f, y * 4.62962963E-08f);
    public static Accel2 CentimetersPerHoursPerMinute(Vector2 v) => new(v.x * 4.62962963E-08f, v.y * 4.62962963E-08f);

    public Vector2 ToCentimetersPerHour2() => new(x * 1296000000f, y * 1296000000f);
    public static Accel2 CentimetersPerHour2(float x, float y) => new(x * 7.716049383E-10f, y * 7.716049383E-10f);
    public static Accel2 CentimetersPerHour2(Vector2 v) => new(v.x * 7.716049383E-10f, v.y * 7.716049383E-10f);

    public Vector2 ToMetersPerMicrosecond2() => new(x * 1E-12f, y * 1E-12f);
    public static Accel2 MetersPerMicrosecond2(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static Accel2 MetersPerMicrosecond2(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMetersPerMicrosecondsPerMillisecond() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 MetersPerMicrosecondsPerMillisecond(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 MetersPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMetersPerMicrosecondsPerSecond() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 MetersPerMicrosecondsPerSecond(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 MetersPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMetersPerMicrosecondsPerMinute() => new(x * 6E-05f, y * 6E-05f);
    public static Accel2 MetersPerMicrosecondsPerMinute(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static Accel2 MetersPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMetersPerMicrosecondsPerHour() => new(x * 0.0036f, y * 0.0036f);
    public static Accel2 MetersPerMicrosecondsPerHour(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static Accel2 MetersPerMicrosecondsPerHour(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMetersPerMillisecondsPerMicrosecond() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 MetersPerMillisecondsPerMicrosecond(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 MetersPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMetersPerMillisecond2() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 MetersPerMillisecond2(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 MetersPerMillisecond2(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMetersPerMillisecondsPerSecond() => new(x * 0.001f, y * 0.001f);
    public static Accel2 MetersPerMillisecondsPerSecond(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 MetersPerMillisecondsPerSecond(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMetersPerMillisecondsPerMinute() => new(x * 0.06f, y * 0.06f);
    public static Accel2 MetersPerMillisecondsPerMinute(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static Accel2 MetersPerMillisecondsPerMinute(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMetersPerMillisecondsPerHour() => new(x * 3.6f, y * 3.6f);
    public static Accel2 MetersPerMillisecondsPerHour(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static Accel2 MetersPerMillisecondsPerHour(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMetersPerSecondsPerMicrosecond() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 MetersPerSecondsPerMicrosecond(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 MetersPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMetersPerSecondsPerMillisecond() => new(x * 0.001f, y * 0.001f);
    public static Accel2 MetersPerSecondsPerMillisecond(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 MetersPerSecondsPerMillisecond(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMetersPerSecond2() => new(x * 1f, y * 1f);
    public static Accel2 MetersPerSecond2(float x, float y) => new(x * 1f, y * 1f);
    public static Accel2 MetersPerSecond2(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToMetersPerSecondsPerMinute() => new(x * 60f, y * 60f);
    public static Accel2 MetersPerSecondsPerMinute(float x, float y) => new(x * 0.01666666667f, y * 0.01666666667f);
    public static Accel2 MetersPerSecondsPerMinute(Vector2 v) => new(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMetersPerSecondsPerHour() => new(x * 3600f, y * 3600f);
    public static Accel2 MetersPerSecondsPerHour(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Accel2 MetersPerSecondsPerHour(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMetersPerMinutesPerMicrosecond() => new(x * 6E-05f, y * 6E-05f);
    public static Accel2 MetersPerMinutesPerMicrosecond(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static Accel2 MetersPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMetersPerMinutesPerMillisecond() => new(x * 0.06f, y * 0.06f);
    public static Accel2 MetersPerMinutesPerMillisecond(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static Accel2 MetersPerMinutesPerMillisecond(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMetersPerMinutesPerSecond() => new(x * 60f, y * 60f);
    public static Accel2 MetersPerMinutesPerSecond(float x, float y) => new(x * 0.01666666667f, y * 0.01666666667f);
    public static Accel2 MetersPerMinutesPerSecond(Vector2 v) => new(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMetersPerMinute2() => new(x * 3600f, y * 3600f);
    public static Accel2 MetersPerMinute2(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Accel2 MetersPerMinute2(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMetersPerMinutesPerHour() => new(x * 216000f, y * 216000f);
    public static Accel2 MetersPerMinutesPerHour(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static Accel2 MetersPerMinutesPerHour(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToMetersPerHoursPerMicrosecond() => new(x * 0.0036f, y * 0.0036f);
    public static Accel2 MetersPerHoursPerMicrosecond(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static Accel2 MetersPerHoursPerMicrosecond(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMetersPerHoursPerMillisecond() => new(x * 3.6f, y * 3.6f);
    public static Accel2 MetersPerHoursPerMillisecond(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static Accel2 MetersPerHoursPerMillisecond(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMetersPerHoursPerSecond() => new(x * 3600f, y * 3600f);
    public static Accel2 MetersPerHoursPerSecond(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static Accel2 MetersPerHoursPerSecond(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMetersPerHoursPerMinute() => new(x * 216000f, y * 216000f);
    public static Accel2 MetersPerHoursPerMinute(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static Accel2 MetersPerHoursPerMinute(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToMetersPerHour2() => new(x * 12960000f, y * 12960000f);
    public static Accel2 MetersPerHour2(float x, float y) => new(x * 7.716049383E-08f, y * 7.716049383E-08f);
    public static Accel2 MetersPerHour2(Vector2 v) => new(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f);

    public Vector2 ToKilometersPerMicrosecond2() => new(x * 1E-15f, y * 1E-15f);
    public static Accel2 KilometersPerMicrosecond2(float x, float y) => new(x * 1E+15f, y * 1E+15f);
    public static Accel2 KilometersPerMicrosecond2(Vector2 v) => new(v.x * 1E+15f, v.y * 1E+15f);

    public Vector2 ToKilometersPerMicrosecondsPerMillisecond() => new(x * 1E-12f, y * 1E-12f);
    public static Accel2 KilometersPerMicrosecondsPerMillisecond(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static Accel2 KilometersPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToKilometersPerMicrosecondsPerSecond() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 KilometersPerMicrosecondsPerSecond(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 KilometersPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilometersPerMicrosecondsPerMinute() => new(x * 6E-08f, y * 6E-08f);
    public static Accel2 KilometersPerMicrosecondsPerMinute(float x, float y) => new(x * 16666666.67f, y * 16666666.67f);
    public static Accel2 KilometersPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 16666666.67f, v.y * 16666666.67f);

    public Vector2 ToKilometersPerMicrosecondsPerHour() => new(x * 3.6E-06f, y * 3.6E-06f);
    public static Accel2 KilometersPerMicrosecondsPerHour(float x, float y) => new(x * 277777.7778f, y * 277777.7778f);
    public static Accel2 KilometersPerMicrosecondsPerHour(Vector2 v) => new(v.x * 277777.7778f, v.y * 277777.7778f);

    public Vector2 ToKilometersPerMillisecondsPerMicrosecond() => new(x * 1E-12f, y * 1E-12f);
    public static Accel2 KilometersPerMillisecondsPerMicrosecond(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static Accel2 KilometersPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToKilometersPerMillisecond2() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 KilometersPerMillisecond2(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 KilometersPerMillisecond2(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilometersPerMillisecondsPerSecond() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 KilometersPerMillisecondsPerSecond(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 KilometersPerMillisecondsPerSecond(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilometersPerMillisecondsPerMinute() => new(x * 6E-05f, y * 6E-05f);
    public static Accel2 KilometersPerMillisecondsPerMinute(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static Accel2 KilometersPerMillisecondsPerMinute(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToKilometersPerMillisecondsPerHour() => new(x * 0.0036f, y * 0.0036f);
    public static Accel2 KilometersPerMillisecondsPerHour(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static Accel2 KilometersPerMillisecondsPerHour(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToKilometersPerSecondsPerMicrosecond() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 KilometersPerSecondsPerMicrosecond(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 KilometersPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToKilometersPerSecondsPerMillisecond() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 KilometersPerSecondsPerMillisecond(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 KilometersPerSecondsPerMillisecond(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilometersPerSecond2() => new(x * 0.001f, y * 0.001f);
    public static Accel2 KilometersPerSecond2(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 KilometersPerSecond2(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilometersPerSecondsPerMinute() => new(x * 0.06f, y * 0.06f);
    public static Accel2 KilometersPerSecondsPerMinute(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static Accel2 KilometersPerSecondsPerMinute(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToKilometersPerSecondsPerHour() => new(x * 3.6f, y * 3.6f);
    public static Accel2 KilometersPerSecondsPerHour(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static Accel2 KilometersPerSecondsPerHour(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToKilometersPerMinutesPerMicrosecond() => new(x * 6E-08f, y * 6E-08f);
    public static Accel2 KilometersPerMinutesPerMicrosecond(float x, float y) => new(x * 16666666.67f, y * 16666666.67f);
    public static Accel2 KilometersPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 16666666.67f, v.y * 16666666.67f);

    public Vector2 ToKilometersPerMinutesPerMillisecond() => new(x * 6E-05f, y * 6E-05f);
    public static Accel2 KilometersPerMinutesPerMillisecond(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static Accel2 KilometersPerMinutesPerMillisecond(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToKilometersPerMinutesPerSecond() => new(x * 0.06f, y * 0.06f);
    public static Accel2 KilometersPerMinutesPerSecond(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static Accel2 KilometersPerMinutesPerSecond(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToKilometersPerMinute2() => new(x * 3.6f, y * 3.6f);
    public static Accel2 KilometersPerMinute2(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static Accel2 KilometersPerMinute2(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToKilometersPerMinutesPerHour() => new(x * 216f, y * 216f);
    public static Accel2 KilometersPerMinutesPerHour(float x, float y) => new(x * 0.00462962963f, y * 0.00462962963f);
    public static Accel2 KilometersPerMinutesPerHour(Vector2 v) => new(v.x * 0.00462962963f, v.y * 0.00462962963f);

    public Vector2 ToKilometersPerHoursPerMicrosecond() => new(x * 3.6E-06f, y * 3.6E-06f);
    public static Accel2 KilometersPerHoursPerMicrosecond(float x, float y) => new(x * 277777.7778f, y * 277777.7778f);
    public static Accel2 KilometersPerHoursPerMicrosecond(Vector2 v) => new(v.x * 277777.7778f, v.y * 277777.7778f);

    public Vector2 ToKilometersPerHoursPerMillisecond() => new(x * 0.0036f, y * 0.0036f);
    public static Accel2 KilometersPerHoursPerMillisecond(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static Accel2 KilometersPerHoursPerMillisecond(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToKilometersPerHoursPerSecond() => new(x * 3.6f, y * 3.6f);
    public static Accel2 KilometersPerHoursPerSecond(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static Accel2 KilometersPerHoursPerSecond(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToKilometersPerHoursPerMinute() => new(x * 216f, y * 216f);
    public static Accel2 KilometersPerHoursPerMinute(float x, float y) => new(x * 0.00462962963f, y * 0.00462962963f);
    public static Accel2 KilometersPerHoursPerMinute(Vector2 v) => new(v.x * 0.00462962963f, v.y * 0.00462962963f);

    public Vector2 ToKilometersPerHour2() => new(x * 12960f, y * 12960f);
    public static Accel2 KilometersPerHour2(float x, float y) => new(x * 7.716049383E-05f, y * 7.716049383E-05f);
    public static Accel2 KilometersPerHour2(Vector2 v) => new(v.x * 7.716049383E-05f, v.y * 7.716049383E-05f);

    public Vector2 ToMegametersPerMicrosecond2() => new(x * 1E-18f, y * 1E-18f);
    public static Accel2 MegametersPerMicrosecond2(float x, float y) => new(x * 1E+18f, y * 1E+18f);
    public static Accel2 MegametersPerMicrosecond2(Vector2 v) => new(v.x * 1E+18f, v.y * 1E+18f);

    public Vector2 ToMegametersPerMicrosecondsPerMillisecond() => new(x * 1E-15f, y * 1E-15f);
    public static Accel2 MegametersPerMicrosecondsPerMillisecond(float x, float y) => new(x * 1E+15f, y * 1E+15f);
    public static Accel2 MegametersPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 1E+15f, v.y * 1E+15f);

    public Vector2 ToMegametersPerMicrosecondsPerSecond() => new(x * 1E-12f, y * 1E-12f);
    public static Accel2 MegametersPerMicrosecondsPerSecond(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static Accel2 MegametersPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMegametersPerMicrosecondsPerMinute() => new(x * 6E-11f, y * 6E-11f);
    public static Accel2 MegametersPerMicrosecondsPerMinute(float x, float y) => new(x * 1.666666667E+10f, y * 1.666666667E+10f);
    public static Accel2 MegametersPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 1.666666667E+10f, v.y * 1.666666667E+10f);

    public Vector2 ToMegametersPerMicrosecondsPerHour() => new(x * 3.6E-09f, y * 3.6E-09f);
    public static Accel2 MegametersPerMicrosecondsPerHour(float x, float y) => new(x * 277777777.8f, y * 277777777.8f);
    public static Accel2 MegametersPerMicrosecondsPerHour(Vector2 v) => new(v.x * 277777777.8f, v.y * 277777777.8f);

    public Vector2 ToMegametersPerMillisecondsPerMicrosecond() => new(x * 1E-15f, y * 1E-15f);
    public static Accel2 MegametersPerMillisecondsPerMicrosecond(float x, float y) => new(x * 1E+15f, y * 1E+15f);
    public static Accel2 MegametersPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 1E+15f, v.y * 1E+15f);

    public Vector2 ToMegametersPerMillisecond2() => new(x * 1E-12f, y * 1E-12f);
    public static Accel2 MegametersPerMillisecond2(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static Accel2 MegametersPerMillisecond2(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMegametersPerMillisecondsPerSecond() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 MegametersPerMillisecondsPerSecond(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 MegametersPerMillisecondsPerSecond(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMegametersPerMillisecondsPerMinute() => new(x * 6E-08f, y * 6E-08f);
    public static Accel2 MegametersPerMillisecondsPerMinute(float x, float y) => new(x * 16666666.67f, y * 16666666.67f);
    public static Accel2 MegametersPerMillisecondsPerMinute(Vector2 v) => new(v.x * 16666666.67f, v.y * 16666666.67f);

    public Vector2 ToMegametersPerMillisecondsPerHour() => new(x * 3.6E-06f, y * 3.6E-06f);
    public static Accel2 MegametersPerMillisecondsPerHour(float x, float y) => new(x * 277777.7778f, y * 277777.7778f);
    public static Accel2 MegametersPerMillisecondsPerHour(Vector2 v) => new(v.x * 277777.7778f, v.y * 277777.7778f);

    public Vector2 ToMegametersPerSecondsPerMicrosecond() => new(x * 1E-12f, y * 1E-12f);
    public static Accel2 MegametersPerSecondsPerMicrosecond(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static Accel2 MegametersPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToMegametersPerSecondsPerMillisecond() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 MegametersPerSecondsPerMillisecond(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 MegametersPerSecondsPerMillisecond(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMegametersPerSecond2() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 MegametersPerSecond2(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 MegametersPerSecond2(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMegametersPerSecondsPerMinute() => new(x * 6E-05f, y * 6E-05f);
    public static Accel2 MegametersPerSecondsPerMinute(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static Accel2 MegametersPerSecondsPerMinute(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMegametersPerSecondsPerHour() => new(x * 0.0036f, y * 0.0036f);
    public static Accel2 MegametersPerSecondsPerHour(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static Accel2 MegametersPerSecondsPerHour(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMegametersPerMinutesPerMicrosecond() => new(x * 6E-11f, y * 6E-11f);
    public static Accel2 MegametersPerMinutesPerMicrosecond(float x, float y) => new(x * 1.666666667E+10f, y * 1.666666667E+10f);
    public static Accel2 MegametersPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 1.666666667E+10f, v.y * 1.666666667E+10f);

    public Vector2 ToMegametersPerMinutesPerMillisecond() => new(x * 6E-08f, y * 6E-08f);
    public static Accel2 MegametersPerMinutesPerMillisecond(float x, float y) => new(x * 16666666.67f, y * 16666666.67f);
    public static Accel2 MegametersPerMinutesPerMillisecond(Vector2 v) => new(v.x * 16666666.67f, v.y * 16666666.67f);

    public Vector2 ToMegametersPerMinutesPerSecond() => new(x * 6E-05f, y * 6E-05f);
    public static Accel2 MegametersPerMinutesPerSecond(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static Accel2 MegametersPerMinutesPerSecond(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMegametersPerMinute2() => new(x * 0.0036f, y * 0.0036f);
    public static Accel2 MegametersPerMinute2(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static Accel2 MegametersPerMinute2(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMegametersPerMinutesPerHour() => new(x * 0.216f, y * 0.216f);
    public static Accel2 MegametersPerMinutesPerHour(float x, float y) => new(x * 4.62962963f, y * 4.62962963f);
    public static Accel2 MegametersPerMinutesPerHour(Vector2 v) => new(v.x * 4.62962963f, v.y * 4.62962963f);

    public Vector2 ToMegametersPerHoursPerMicrosecond() => new(x * 3.6E-09f, y * 3.6E-09f);
    public static Accel2 MegametersPerHoursPerMicrosecond(float x, float y) => new(x * 277777777.8f, y * 277777777.8f);
    public static Accel2 MegametersPerHoursPerMicrosecond(Vector2 v) => new(v.x * 277777777.8f, v.y * 277777777.8f);

    public Vector2 ToMegametersPerHoursPerMillisecond() => new(x * 3.6E-06f, y * 3.6E-06f);
    public static Accel2 MegametersPerHoursPerMillisecond(float x, float y) => new(x * 277777.7778f, y * 277777.7778f);
    public static Accel2 MegametersPerHoursPerMillisecond(Vector2 v) => new(v.x * 277777.7778f, v.y * 277777.7778f);

    public Vector2 ToMegametersPerHoursPerSecond() => new(x * 0.0036f, y * 0.0036f);
    public static Accel2 MegametersPerHoursPerSecond(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static Accel2 MegametersPerHoursPerSecond(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMegametersPerHoursPerMinute() => new(x * 0.216f, y * 0.216f);
    public static Accel2 MegametersPerHoursPerMinute(float x, float y) => new(x * 4.62962963f, y * 4.62962963f);
    public static Accel2 MegametersPerHoursPerMinute(Vector2 v) => new(v.x * 4.62962963f, v.y * 4.62962963f);

    public Vector2 ToMegametersPerHour2() => new(x * 12.96f, y * 12.96f);
    public static Accel2 MegametersPerHour2(float x, float y) => new(x * 0.07716049383f, y * 0.07716049383f);
    public static Accel2 MegametersPerHour2(Vector2 v) => new(v.x * 0.07716049383f, v.y * 0.07716049383f);

    public Vector2 ToMillinewtonsPerMilligram() => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 MillinewtonsPerMilligram(float x, float y) => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 MillinewtonsPerMilligram(Vector2 v) => new(v.x * 1E-09f, v.y * 1E-09f);

    public Vector2 ToMillinewtonsPerGram() => new(x * 1000000f, y * 1000000f);
    public static Accel2 MillinewtonsPerGram(float x, float y) => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 MillinewtonsPerGram(Vector2 v) => new(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToMillinewtonsPerKilogram() => new(x * 1000f, y * 1000f);
    public static Accel2 MillinewtonsPerKilogram(float x, float y) => new(x * 0.001f, y * 0.001f);
    public static Accel2 MillinewtonsPerKilogram(Vector2 v) => new(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtonsPerTon() => new(x * 1f, y * 1f);
    public static Accel2 MillinewtonsPerTon(float x, float y) => new(x * 1f, y * 1f);
    public static Accel2 MillinewtonsPerTon(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerKiloton() => new(x * 0.001f, y * 0.001f);
    public static Accel2 MillinewtonsPerKiloton(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 MillinewtonsPerKiloton(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerMilligram() => new(x * 1000000f, y * 1000000f);
    public static Accel2 NewtonsPerMilligram(float x, float y) => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 NewtonsPerMilligram(Vector2 v) => new(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToNewtonsPerGram() => new(x * 1000f, y * 1000f);
    public static Accel2 NewtonsPerGram(float x, float y) => new(x * 0.001f, y * 0.001f);
    public static Accel2 NewtonsPerGram(Vector2 v) => new(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToNewtonsPerKilogram() => new(x * 1f, y * 1f);
    public static Accel2 NewtonsPerKilogram(float x, float y) => new(x * 1f, y * 1f);
    public static Accel2 NewtonsPerKilogram(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtonsPerTon() => new(x * 0.001f, y * 0.001f);
    public static Accel2 NewtonsPerTon(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 NewtonsPerTon(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerKiloton() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 NewtonsPerKiloton(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 NewtonsPerKiloton(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerMilligram() => new(x * 1000f, y * 1000f);
    public static Accel2 KilonewtonsPerMilligram(float x, float y) => new(x * 0.001f, y * 0.001f);
    public static Accel2 KilonewtonsPerMilligram(Vector2 v) => new(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToKilonewtonsPerGram() => new(x * 1f, y * 1f);
    public static Accel2 KilonewtonsPerGram(float x, float y) => new(x * 1f, y * 1f);
    public static Accel2 KilonewtonsPerGram(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToKilonewtonsPerKilogram() => new(x * 0.001f, y * 0.001f);
    public static Accel2 KilonewtonsPerKilogram(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 KilonewtonsPerKilogram(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtonsPerTon() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 KilonewtonsPerTon(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 KilonewtonsPerTon(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerKiloton() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 KilonewtonsPerKiloton(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 KilonewtonsPerKiloton(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerMilligram() => new(x * 1f, y * 1f);
    public static Accel2 MeganewtonsPerMilligram(float x, float y) => new(x * 1f, y * 1f);
    public static Accel2 MeganewtonsPerMilligram(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToMeganewtonsPerGram() => new(x * 0.001f, y * 0.001f);
    public static Accel2 MeganewtonsPerGram(float x, float y) => new(x * 1000f, y * 1000f);
    public static Accel2 MeganewtonsPerGram(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeganewtonsPerKilogram() => new(x * 1E-06f, y * 1E-06f);
    public static Accel2 MeganewtonsPerKilogram(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static Accel2 MeganewtonsPerKilogram(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtonsPerTon() => new(x * 1E-09f, y * 1E-09f);
    public static Accel2 MeganewtonsPerTon(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static Accel2 MeganewtonsPerTon(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerKiloton() => new(x * 1E-12f, y * 1E-12f);
    public static Accel2 MeganewtonsPerKiloton(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static Accel2 MeganewtonsPerKiloton(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public static Accel2 operator +(Accel2 a, Accel2 b) => new(a.x + b.x, a.y + b.y);
    public static Accel2 operator -(Accel2 a, Accel2 b) => new(a.x - b.x, a.y - b.y);
    
    public static Accel2 operator *(Accel2 a, Accel2 b) => new(a.x * b.x, a.y * b.y);
    public static Accel2 operator /(Accel2 a, Accel2 b) => new(a.x / b.x, a.y / b.y);
    
    public Velocity2 Velocity2(Time v) => new(v * x, v * y);
    public Time Time(Velocity2 v) => new(v.magnitude / magnitude);

    public Accel2(Velocity2 a, Time b) : this(a.Accel2(b)) { }
    public Accel2(Time b, Velocity2 a) : this(a.Accel2(b)) { }

    public Force2 Force2(Mass v) => new(v * x, v * y);
    public Mass Mass(Force2 v) => new(v.magnitude / magnitude);

    public Accel2(Force2 a, Mass b) : this(a.Accel2(b)) { }
    public Accel2(Mass b, Force2 a) : this(a.Accel2(b)) { }

}
}

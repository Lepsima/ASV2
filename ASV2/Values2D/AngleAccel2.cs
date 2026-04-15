using System;
using UnityEngine;

namespace Lepsima.ASV {
public struct AngleAccel2 : IAutoUnit2 {
    public float x, y;
    
    public AngleAccel2(float x, float y) {
        this.x = x;
        this.y = y;
    }
    
    public AngleAccel2(Vector2 v2) {
        x = v2.x;
        y = v2.y;
    }

    public Vector2 vector => this;
    public static implicit operator Vector2(AngleAccel2 v) => new(v.x, v.y);

    public Direction3 normalized => new(vector.normalized);
    public AngleAccel sqrMagnitude => new(vector.sqrMagnitude);
    public AngleAccel magnitude => new(vector.magnitude);

    public Vector2 ToDegreesPerMicrosecond2() => new(x * 1E-12f, y * 1E-12f);
    public static AngleAccel2 DegreesPerMicrosecond2(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static AngleAccel2 DegreesPerMicrosecond2(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public Vector2 ToDegreesPerMicrosecondsPerMillisecond() => new(x * 1E-09f, y * 1E-09f);
    public static AngleAccel2 DegreesPerMicrosecondsPerMillisecond(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static AngleAccel2 DegreesPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToDegreesPerMicrosecondsPerSecond() => new(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 DegreesPerMicrosecondsPerSecond(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static AngleAccel2 DegreesPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToDegreesPerMicrosecondsPerMinute() => new(x * 6E-05f, y * 6E-05f);
    public static AngleAccel2 DegreesPerMicrosecondsPerMinute(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static AngleAccel2 DegreesPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToDegreesPerMicrosecondsPerHour() => new(x * 0.0036f, y * 0.0036f);
    public static AngleAccel2 DegreesPerMicrosecondsPerHour(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static AngleAccel2 DegreesPerMicrosecondsPerHour(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToDegreesPerMillisecondsPerMicrosecond() => new(x * 1E-09f, y * 1E-09f);
    public static AngleAccel2 DegreesPerMillisecondsPerMicrosecond(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static AngleAccel2 DegreesPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToDegreesPerMillisecond2() => new(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 DegreesPerMillisecond2(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static AngleAccel2 DegreesPerMillisecond2(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToDegreesPerMillisecondsPerSecond() => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 DegreesPerMillisecondsPerSecond(float x, float y) => new(x * 1000f, y * 1000f);
    public static AngleAccel2 DegreesPerMillisecondsPerSecond(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToDegreesPerMillisecondsPerMinute() => new(x * 0.06f, y * 0.06f);
    public static AngleAccel2 DegreesPerMillisecondsPerMinute(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static AngleAccel2 DegreesPerMillisecondsPerMinute(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToDegreesPerMillisecondsPerHour() => new(x * 3.6f, y * 3.6f);
    public static AngleAccel2 DegreesPerMillisecondsPerHour(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static AngleAccel2 DegreesPerMillisecondsPerHour(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToDegreesPerSecondsPerMicrosecond() => new(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 DegreesPerSecondsPerMicrosecond(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static AngleAccel2 DegreesPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToDegreesPerSecondsPerMillisecond() => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 DegreesPerSecondsPerMillisecond(float x, float y) => new(x * 1000f, y * 1000f);
    public static AngleAccel2 DegreesPerSecondsPerMillisecond(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToDegreesPerSecond2() => new(x * 1f, y * 1f);
    public static AngleAccel2 DegreesPerSecond2(float x, float y) => new(x * 1f, y * 1f);
    public static AngleAccel2 DegreesPerSecond2(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToDegreesPerSecondsPerMinute() => new(x * 60f, y * 60f);
    public static AngleAccel2 DegreesPerSecondsPerMinute(float x, float y) => new(x * 0.01666666667f, y * 0.01666666667f);
    public static AngleAccel2 DegreesPerSecondsPerMinute(Vector2 v) => new(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToDegreesPerSecondsPerHour() => new(x * 3600f, y * 3600f);
    public static AngleAccel2 DegreesPerSecondsPerHour(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleAccel2 DegreesPerSecondsPerHour(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToDegreesPerMinutesPerMicrosecond() => new(x * 6E-05f, y * 6E-05f);
    public static AngleAccel2 DegreesPerMinutesPerMicrosecond(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static AngleAccel2 DegreesPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToDegreesPerMinutesPerMillisecond() => new(x * 0.06f, y * 0.06f);
    public static AngleAccel2 DegreesPerMinutesPerMillisecond(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static AngleAccel2 DegreesPerMinutesPerMillisecond(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToDegreesPerMinutesPerSecond() => new(x * 60f, y * 60f);
    public static AngleAccel2 DegreesPerMinutesPerSecond(float x, float y) => new(x * 0.01666666667f, y * 0.01666666667f);
    public static AngleAccel2 DegreesPerMinutesPerSecond(Vector2 v) => new(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToDegreesPerMinute2() => new(x * 3600f, y * 3600f);
    public static AngleAccel2 DegreesPerMinute2(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleAccel2 DegreesPerMinute2(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToDegreesPerMinutesPerHour() => new(x * 216000f, y * 216000f);
    public static AngleAccel2 DegreesPerMinutesPerHour(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleAccel2 DegreesPerMinutesPerHour(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToDegreesPerHoursPerMicrosecond() => new(x * 0.0036f, y * 0.0036f);
    public static AngleAccel2 DegreesPerHoursPerMicrosecond(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static AngleAccel2 DegreesPerHoursPerMicrosecond(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToDegreesPerHoursPerMillisecond() => new(x * 3.6f, y * 3.6f);
    public static AngleAccel2 DegreesPerHoursPerMillisecond(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static AngleAccel2 DegreesPerHoursPerMillisecond(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToDegreesPerHoursPerSecond() => new(x * 3600f, y * 3600f);
    public static AngleAccel2 DegreesPerHoursPerSecond(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleAccel2 DegreesPerHoursPerSecond(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToDegreesPerHoursPerMinute() => new(x * 216000f, y * 216000f);
    public static AngleAccel2 DegreesPerHoursPerMinute(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleAccel2 DegreesPerHoursPerMinute(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToDegreesPerHour2() => new(x * 12960000f, y * 12960000f);
    public static AngleAccel2 DegreesPerHour2(float x, float y) => new(x * 7.716049383E-08f, y * 7.716049383E-08f);
    public static AngleAccel2 DegreesPerHour2(Vector2 v) => new(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f);

    public Vector2 ToRadiansPerMicrosecond2() => new(x * 5.729577996E-11f, y * 5.729577996E-11f);
    public static AngleAccel2 RadiansPerMicrosecond2(float x, float y) => new(x * 1.745329238E+10f, y * 1.745329238E+10f);
    public static AngleAccel2 RadiansPerMicrosecond2(Vector2 v) => new(v.x * 1.745329238E+10f, v.y * 1.745329238E+10f);

    public Vector2 ToRadiansPerMicrosecondsPerMillisecond() => new(x * 5.729577996E-08f, y * 5.729577996E-08f);
    public static AngleAccel2 RadiansPerMicrosecondsPerMillisecond(float x, float y) => new(x * 17453292.38f, y * 17453292.38f);
    public static AngleAccel2 RadiansPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 17453292.38f, v.y * 17453292.38f);

    public Vector2 ToRadiansPerMicrosecondsPerSecond() => new(x * 5.729577996E-05f, y * 5.729577996E-05f);
    public static AngleAccel2 RadiansPerMicrosecondsPerSecond(float x, float y) => new(x * 17453.29238f, y * 17453.29238f);
    public static AngleAccel2 RadiansPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 17453.29238f, v.y * 17453.29238f);

    public Vector2 ToRadiansPerMicrosecondsPerMinute() => new(x * 0.003437746797f, y * 0.003437746797f);
    public static AngleAccel2 RadiansPerMicrosecondsPerMinute(float x, float y) => new(x * 290.8882064f, y * 290.8882064f);
    public static AngleAccel2 RadiansPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 290.8882064f, v.y * 290.8882064f);

    public Vector2 ToRadiansPerMicrosecondsPerHour() => new(x * 0.2062648078f, y * 0.2062648078f);
    public static AngleAccel2 RadiansPerMicrosecondsPerHour(float x, float y) => new(x * 4.848136774f, y * 4.848136774f);
    public static AngleAccel2 RadiansPerMicrosecondsPerHour(Vector2 v) => new(v.x * 4.848136774f, v.y * 4.848136774f);

    public Vector2 ToRadiansPerMillisecondsPerMicrosecond() => new(x * 5.729577996E-08f, y * 5.729577996E-08f);
    public static AngleAccel2 RadiansPerMillisecondsPerMicrosecond(float x, float y) => new(x * 17453292.38f, y * 17453292.38f);
    public static AngleAccel2 RadiansPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 17453292.38f, v.y * 17453292.38f);

    public Vector2 ToRadiansPerMillisecond2() => new(x * 5.729577996E-05f, y * 5.729577996E-05f);
    public static AngleAccel2 RadiansPerMillisecond2(float x, float y) => new(x * 17453.29238f, y * 17453.29238f);
    public static AngleAccel2 RadiansPerMillisecond2(Vector2 v) => new(v.x * 17453.29238f, v.y * 17453.29238f);

    public Vector2 ToRadiansPerMillisecondsPerSecond() => new(x * 0.05729577996f, y * 0.05729577996f);
    public static AngleAccel2 RadiansPerMillisecondsPerSecond(float x, float y) => new(x * 17.45329238f, y * 17.45329238f);
    public static AngleAccel2 RadiansPerMillisecondsPerSecond(Vector2 v) => new(v.x * 17.45329238f, v.y * 17.45329238f);

    public Vector2 ToRadiansPerMillisecondsPerMinute() => new(x * 3.437746797f, y * 3.437746797f);
    public static AngleAccel2 RadiansPerMillisecondsPerMinute(float x, float y) => new(x * 0.2908882064f, y * 0.2908882064f);
    public static AngleAccel2 RadiansPerMillisecondsPerMinute(Vector2 v) => new(v.x * 0.2908882064f, v.y * 0.2908882064f);

    public Vector2 ToRadiansPerMillisecondsPerHour() => new(x * 206.2648078f, y * 206.2648078f);
    public static AngleAccel2 RadiansPerMillisecondsPerHour(float x, float y) => new(x * 0.004848136774f, y * 0.004848136774f);
    public static AngleAccel2 RadiansPerMillisecondsPerHour(Vector2 v) => new(v.x * 0.004848136774f, v.y * 0.004848136774f);

    public Vector2 ToRadiansPerSecondsPerMicrosecond() => new(x * 5.729577996E-05f, y * 5.729577996E-05f);
    public static AngleAccel2 RadiansPerSecondsPerMicrosecond(float x, float y) => new(x * 17453.29238f, y * 17453.29238f);
    public static AngleAccel2 RadiansPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 17453.29238f, v.y * 17453.29238f);

    public Vector2 ToRadiansPerSecondsPerMillisecond() => new(x * 0.05729577996f, y * 0.05729577996f);
    public static AngleAccel2 RadiansPerSecondsPerMillisecond(float x, float y) => new(x * 17.45329238f, y * 17.45329238f);
    public static AngleAccel2 RadiansPerSecondsPerMillisecond(Vector2 v) => new(v.x * 17.45329238f, v.y * 17.45329238f);

    public Vector2 ToRadiansPerSecond2() => new(x * 57.29577996f, y * 57.29577996f);
    public static AngleAccel2 RadiansPerSecond2(float x, float y) => new(x * 0.01745329238f, y * 0.01745329238f);
    public static AngleAccel2 RadiansPerSecond2(Vector2 v) => new(v.x * 0.01745329238f, v.y * 0.01745329238f);

    public Vector2 ToRadiansPerSecondsPerMinute() => new(x * 3437.746797f, y * 3437.746797f);
    public static AngleAccel2 RadiansPerSecondsPerMinute(float x, float y) => new(x * 0.0002908882064f, y * 0.0002908882064f);
    public static AngleAccel2 RadiansPerSecondsPerMinute(Vector2 v) => new(v.x * 0.0002908882064f, v.y * 0.0002908882064f);

    public Vector2 ToRadiansPerSecondsPerHour() => new(x * 206264.8078f, y * 206264.8078f);
    public static AngleAccel2 RadiansPerSecondsPerHour(float x, float y) => new(x * 4.848136774E-06f, y * 4.848136774E-06f);
    public static AngleAccel2 RadiansPerSecondsPerHour(Vector2 v) => new(v.x * 4.848136774E-06f, v.y * 4.848136774E-06f);

    public Vector2 ToRadiansPerMinutesPerMicrosecond() => new(x * 0.003437746797f, y * 0.003437746797f);
    public static AngleAccel2 RadiansPerMinutesPerMicrosecond(float x, float y) => new(x * 290.8882064f, y * 290.8882064f);
    public static AngleAccel2 RadiansPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 290.8882064f, v.y * 290.8882064f);

    public Vector2 ToRadiansPerMinutesPerMillisecond() => new(x * 3.437746797f, y * 3.437746797f);
    public static AngleAccel2 RadiansPerMinutesPerMillisecond(float x, float y) => new(x * 0.2908882064f, y * 0.2908882064f);
    public static AngleAccel2 RadiansPerMinutesPerMillisecond(Vector2 v) => new(v.x * 0.2908882064f, v.y * 0.2908882064f);

    public Vector2 ToRadiansPerMinutesPerSecond() => new(x * 3437.746797f, y * 3437.746797f);
    public static AngleAccel2 RadiansPerMinutesPerSecond(float x, float y) => new(x * 0.0002908882064f, y * 0.0002908882064f);
    public static AngleAccel2 RadiansPerMinutesPerSecond(Vector2 v) => new(v.x * 0.0002908882064f, v.y * 0.0002908882064f);

    public Vector2 ToRadiansPerMinute2() => new(x * 206264.8078f, y * 206264.8078f);
    public static AngleAccel2 RadiansPerMinute2(float x, float y) => new(x * 4.848136774E-06f, y * 4.848136774E-06f);
    public static AngleAccel2 RadiansPerMinute2(Vector2 v) => new(v.x * 4.848136774E-06f, v.y * 4.848136774E-06f);

    public Vector2 ToRadiansPerMinutesPerHour() => new(x * 12375888.47f, y * 12375888.47f);
    public static AngleAccel2 RadiansPerMinutesPerHour(float x, float y) => new(x * 8.080227956E-08f, y * 8.080227956E-08f);
    public static AngleAccel2 RadiansPerMinutesPerHour(Vector2 v) => new(v.x * 8.080227956E-08f, v.y * 8.080227956E-08f);

    public Vector2 ToRadiansPerHoursPerMicrosecond() => new(x * 0.2062648078f, y * 0.2062648078f);
    public static AngleAccel2 RadiansPerHoursPerMicrosecond(float x, float y) => new(x * 4.848136774f, y * 4.848136774f);
    public static AngleAccel2 RadiansPerHoursPerMicrosecond(Vector2 v) => new(v.x * 4.848136774f, v.y * 4.848136774f);

    public Vector2 ToRadiansPerHoursPerMillisecond() => new(x * 206.2648078f, y * 206.2648078f);
    public static AngleAccel2 RadiansPerHoursPerMillisecond(float x, float y) => new(x * 0.004848136774f, y * 0.004848136774f);
    public static AngleAccel2 RadiansPerHoursPerMillisecond(Vector2 v) => new(v.x * 0.004848136774f, v.y * 0.004848136774f);

    public Vector2 ToRadiansPerHoursPerSecond() => new(x * 206264.8078f, y * 206264.8078f);
    public static AngleAccel2 RadiansPerHoursPerSecond(float x, float y) => new(x * 4.848136774E-06f, y * 4.848136774E-06f);
    public static AngleAccel2 RadiansPerHoursPerSecond(Vector2 v) => new(v.x * 4.848136774E-06f, v.y * 4.848136774E-06f);

    public Vector2 ToRadiansPerHoursPerMinute() => new(x * 12375888.47f, y * 12375888.47f);
    public static AngleAccel2 RadiansPerHoursPerMinute(float x, float y) => new(x * 8.080227956E-08f, y * 8.080227956E-08f);
    public static AngleAccel2 RadiansPerHoursPerMinute(Vector2 v) => new(v.x * 8.080227956E-08f, v.y * 8.080227956E-08f);

    public Vector2 ToRadiansPerHour2() => new(x * 742553308.2f, y * 742553308.2f);
    public static AngleAccel2 RadiansPerHour2(float x, float y) => new(x * 1.346704659E-09f, y * 1.346704659E-09f);
    public static AngleAccel2 RadiansPerHour2(Vector2 v) => new(v.x * 1.346704659E-09f, v.y * 1.346704659E-09f);

    public Vector2 ToTurnsPerMicrosecond2() => new(x * 2.777777778E-15f, y * 2.777777778E-15f);
    public static AngleAccel2 TurnsPerMicrosecond2(float x, float y) => new(x * 3.6E+14f, y * 3.6E+14f);
    public static AngleAccel2 TurnsPerMicrosecond2(Vector2 v) => new(v.x * 3.6E+14f, v.y * 3.6E+14f);

    public Vector2 ToTurnsPerMicrosecondsPerMillisecond() => new(x * 2.777777778E-12f, y * 2.777777778E-12f);
    public static AngleAccel2 TurnsPerMicrosecondsPerMillisecond(float x, float y) => new(x * 3.6E+11f, y * 3.6E+11f);
    public static AngleAccel2 TurnsPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 3.6E+11f, v.y * 3.6E+11f);

    public Vector2 ToTurnsPerMicrosecondsPerSecond() => new(x * 2.777777778E-09f, y * 2.777777778E-09f);
    public static AngleAccel2 TurnsPerMicrosecondsPerSecond(float x, float y) => new(x * 360000000f, y * 360000000f);
    public static AngleAccel2 TurnsPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 360000000f, v.y * 360000000f);

    public Vector2 ToTurnsPerMicrosecondsPerMinute() => new(x * 1.666666667E-07f, y * 1.666666667E-07f);
    public static AngleAccel2 TurnsPerMicrosecondsPerMinute(float x, float y) => new(x * 6000000f, y * 6000000f);
    public static AngleAccel2 TurnsPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 6000000f, v.y * 6000000f);

    public Vector2 ToTurnsPerMicrosecondsPerHour() => new(x * 1E-05f, y * 1E-05f);
    public static AngleAccel2 TurnsPerMicrosecondsPerHour(float x, float y) => new(x * 100000f, y * 100000f);
    public static AngleAccel2 TurnsPerMicrosecondsPerHour(Vector2 v) => new(v.x * 100000f, v.y * 100000f);

    public Vector2 ToTurnsPerMillisecondsPerMicrosecond() => new(x * 2.777777778E-12f, y * 2.777777778E-12f);
    public static AngleAccel2 TurnsPerMillisecondsPerMicrosecond(float x, float y) => new(x * 3.6E+11f, y * 3.6E+11f);
    public static AngleAccel2 TurnsPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 3.6E+11f, v.y * 3.6E+11f);

    public Vector2 ToTurnsPerMillisecond2() => new(x * 2.777777778E-09f, y * 2.777777778E-09f);
    public static AngleAccel2 TurnsPerMillisecond2(float x, float y) => new(x * 360000000f, y * 360000000f);
    public static AngleAccel2 TurnsPerMillisecond2(Vector2 v) => new(v.x * 360000000f, v.y * 360000000f);

    public Vector2 ToTurnsPerMillisecondsPerSecond() => new(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static AngleAccel2 TurnsPerMillisecondsPerSecond(float x, float y) => new(x * 360000f, y * 360000f);
    public static AngleAccel2 TurnsPerMillisecondsPerSecond(Vector2 v) => new(v.x * 360000f, v.y * 360000f);

    public Vector2 ToTurnsPerMillisecondsPerMinute() => new(x * 0.0001666666667f, y * 0.0001666666667f);
    public static AngleAccel2 TurnsPerMillisecondsPerMinute(float x, float y) => new(x * 6000f, y * 6000f);
    public static AngleAccel2 TurnsPerMillisecondsPerMinute(Vector2 v) => new(v.x * 6000f, v.y * 6000f);

    public Vector2 ToTurnsPerMillisecondsPerHour() => new(x * 0.01f, y * 0.01f);
    public static AngleAccel2 TurnsPerMillisecondsPerHour(float x, float y) => new(x * 100f, y * 100f);
    public static AngleAccel2 TurnsPerMillisecondsPerHour(Vector2 v) => new(v.x * 100f, v.y * 100f);

    public Vector2 ToTurnsPerSecondsPerMicrosecond() => new(x * 2.777777778E-09f, y * 2.777777778E-09f);
    public static AngleAccel2 TurnsPerSecondsPerMicrosecond(float x, float y) => new(x * 360000000f, y * 360000000f);
    public static AngleAccel2 TurnsPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 360000000f, v.y * 360000000f);

    public Vector2 ToTurnsPerSecondsPerMillisecond() => new(x * 2.777777778E-06f, y * 2.777777778E-06f);
    public static AngleAccel2 TurnsPerSecondsPerMillisecond(float x, float y) => new(x * 360000f, y * 360000f);
    public static AngleAccel2 TurnsPerSecondsPerMillisecond(Vector2 v) => new(v.x * 360000f, v.y * 360000f);

    public Vector2 ToTurnsPerSecond2() => new(x * 0.002777777778f, y * 0.002777777778f);
    public static AngleAccel2 TurnsPerSecond2(float x, float y) => new(x * 360f, y * 360f);
    public static AngleAccel2 TurnsPerSecond2(Vector2 v) => new(v.x * 360f, v.y * 360f);

    public Vector2 ToTurnsPerSecondsPerMinute() => new(x * 0.1666666667f, y * 0.1666666667f);
    public static AngleAccel2 TurnsPerSecondsPerMinute(float x, float y) => new(x * 6f, y * 6f);
    public static AngleAccel2 TurnsPerSecondsPerMinute(Vector2 v) => new(v.x * 6f, v.y * 6f);

    public Vector2 ToTurnsPerSecondsPerHour() => new(x * 10f, y * 10f);
    public static AngleAccel2 TurnsPerSecondsPerHour(float x, float y) => new(x * 0.1f, y * 0.1f);
    public static AngleAccel2 TurnsPerSecondsPerHour(Vector2 v) => new(v.x * 0.1f, v.y * 0.1f);

    public Vector2 ToTurnsPerMinutesPerMicrosecond() => new(x * 1.666666667E-07f, y * 1.666666667E-07f);
    public static AngleAccel2 TurnsPerMinutesPerMicrosecond(float x, float y) => new(x * 6000000f, y * 6000000f);
    public static AngleAccel2 TurnsPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 6000000f, v.y * 6000000f);

    public Vector2 ToTurnsPerMinutesPerMillisecond() => new(x * 0.0001666666667f, y * 0.0001666666667f);
    public static AngleAccel2 TurnsPerMinutesPerMillisecond(float x, float y) => new(x * 6000f, y * 6000f);
    public static AngleAccel2 TurnsPerMinutesPerMillisecond(Vector2 v) => new(v.x * 6000f, v.y * 6000f);

    public Vector2 ToTurnsPerMinutesPerSecond() => new(x * 0.1666666667f, y * 0.1666666667f);
    public static AngleAccel2 TurnsPerMinutesPerSecond(float x, float y) => new(x * 6f, y * 6f);
    public static AngleAccel2 TurnsPerMinutesPerSecond(Vector2 v) => new(v.x * 6f, v.y * 6f);

    public Vector2 ToTurnsPerMinute2() => new(x * 10f, y * 10f);
    public static AngleAccel2 TurnsPerMinute2(float x, float y) => new(x * 0.1f, y * 0.1f);
    public static AngleAccel2 TurnsPerMinute2(Vector2 v) => new(v.x * 0.1f, v.y * 0.1f);

    public Vector2 ToTurnsPerMinutesPerHour() => new(x * 600f, y * 600f);
    public static AngleAccel2 TurnsPerMinutesPerHour(float x, float y) => new(x * 0.001666666667f, y * 0.001666666667f);
    public static AngleAccel2 TurnsPerMinutesPerHour(Vector2 v) => new(v.x * 0.001666666667f, v.y * 0.001666666667f);

    public Vector2 ToTurnsPerHoursPerMicrosecond() => new(x * 1E-05f, y * 1E-05f);
    public static AngleAccel2 TurnsPerHoursPerMicrosecond(float x, float y) => new(x * 100000f, y * 100000f);
    public static AngleAccel2 TurnsPerHoursPerMicrosecond(Vector2 v) => new(v.x * 100000f, v.y * 100000f);

    public Vector2 ToTurnsPerHoursPerMillisecond() => new(x * 0.01f, y * 0.01f);
    public static AngleAccel2 TurnsPerHoursPerMillisecond(float x, float y) => new(x * 100f, y * 100f);
    public static AngleAccel2 TurnsPerHoursPerMillisecond(Vector2 v) => new(v.x * 100f, v.y * 100f);

    public Vector2 ToTurnsPerHoursPerSecond() => new(x * 10f, y * 10f);
    public static AngleAccel2 TurnsPerHoursPerSecond(float x, float y) => new(x * 0.1f, y * 0.1f);
    public static AngleAccel2 TurnsPerHoursPerSecond(Vector2 v) => new(v.x * 0.1f, v.y * 0.1f);

    public Vector2 ToTurnsPerHoursPerMinute() => new(x * 600f, y * 600f);
    public static AngleAccel2 TurnsPerHoursPerMinute(float x, float y) => new(x * 0.001666666667f, y * 0.001666666667f);
    public static AngleAccel2 TurnsPerHoursPerMinute(Vector2 v) => new(v.x * 0.001666666667f, v.y * 0.001666666667f);

    public Vector2 ToTurnsPerHour2() => new(x * 36000f, y * 36000f);
    public static AngleAccel2 TurnsPerHour2(float x, float y) => new(x * 2.777777778E-05f, y * 2.777777778E-05f);
    public static AngleAccel2 TurnsPerHour2(Vector2 v) => new(v.x * 2.777777778E-05f, v.y * 2.777777778E-05f);

    public Vector2 ToMinuteDegreesPerMicrosecond2() => new(x * 6E-11f, y * 6E-11f);
    public static AngleAccel2 MinuteDegreesPerMicrosecond2(float x, float y) => new(x * 1.666666667E+10f, y * 1.666666667E+10f);
    public static AngleAccel2 MinuteDegreesPerMicrosecond2(Vector2 v) => new(v.x * 1.666666667E+10f, v.y * 1.666666667E+10f);

    public Vector2 ToMinuteDegreesPerMicrosecondsPerMillisecond() => new(x * 6E-08f, y * 6E-08f);
    public static AngleAccel2 MinuteDegreesPerMicrosecondsPerMillisecond(float x, float y) => new(x * 16666666.67f, y * 16666666.67f);
    public static AngleAccel2 MinuteDegreesPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 16666666.67f, v.y * 16666666.67f);

    public Vector2 ToMinuteDegreesPerMicrosecondsPerSecond() => new(x * 6E-05f, y * 6E-05f);
    public static AngleAccel2 MinuteDegreesPerMicrosecondsPerSecond(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static AngleAccel2 MinuteDegreesPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMinuteDegreesPerMicrosecondsPerMinute() => new(x * 0.0036f, y * 0.0036f);
    public static AngleAccel2 MinuteDegreesPerMicrosecondsPerMinute(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static AngleAccel2 MinuteDegreesPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMinuteDegreesPerMicrosecondsPerHour() => new(x * 0.216f, y * 0.216f);
    public static AngleAccel2 MinuteDegreesPerMicrosecondsPerHour(float x, float y) => new(x * 4.62962963f, y * 4.62962963f);
    public static AngleAccel2 MinuteDegreesPerMicrosecondsPerHour(Vector2 v) => new(v.x * 4.62962963f, v.y * 4.62962963f);

    public Vector2 ToMinuteDegreesPerMillisecondsPerMicrosecond() => new(x * 6E-08f, y * 6E-08f);
    public static AngleAccel2 MinuteDegreesPerMillisecondsPerMicrosecond(float x, float y) => new(x * 16666666.67f, y * 16666666.67f);
    public static AngleAccel2 MinuteDegreesPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 16666666.67f, v.y * 16666666.67f);

    public Vector2 ToMinuteDegreesPerMillisecond2() => new(x * 6E-05f, y * 6E-05f);
    public static AngleAccel2 MinuteDegreesPerMillisecond2(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static AngleAccel2 MinuteDegreesPerMillisecond2(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMinuteDegreesPerMillisecondsPerSecond() => new(x * 0.06f, y * 0.06f);
    public static AngleAccel2 MinuteDegreesPerMillisecondsPerSecond(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static AngleAccel2 MinuteDegreesPerMillisecondsPerSecond(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMinuteDegreesPerMillisecondsPerMinute() => new(x * 3.6f, y * 3.6f);
    public static AngleAccel2 MinuteDegreesPerMillisecondsPerMinute(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static AngleAccel2 MinuteDegreesPerMillisecondsPerMinute(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMinuteDegreesPerMillisecondsPerHour() => new(x * 216f, y * 216f);
    public static AngleAccel2 MinuteDegreesPerMillisecondsPerHour(float x, float y) => new(x * 0.00462962963f, y * 0.00462962963f);
    public static AngleAccel2 MinuteDegreesPerMillisecondsPerHour(Vector2 v) => new(v.x * 0.00462962963f, v.y * 0.00462962963f);

    public Vector2 ToMinuteDegreesPerSecondsPerMicrosecond() => new(x * 6E-05f, y * 6E-05f);
    public static AngleAccel2 MinuteDegreesPerSecondsPerMicrosecond(float x, float y) => new(x * 16666.66667f, y * 16666.66667f);
    public static AngleAccel2 MinuteDegreesPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 16666.66667f, v.y * 16666.66667f);

    public Vector2 ToMinuteDegreesPerSecondsPerMillisecond() => new(x * 0.06f, y * 0.06f);
    public static AngleAccel2 MinuteDegreesPerSecondsPerMillisecond(float x, float y) => new(x * 16.66666667f, y * 16.66666667f);
    public static AngleAccel2 MinuteDegreesPerSecondsPerMillisecond(Vector2 v) => new(v.x * 16.66666667f, v.y * 16.66666667f);

    public Vector2 ToMinuteDegreesPerSecond2() => new(x * 60f, y * 60f);
    public static AngleAccel2 MinuteDegreesPerSecond2(float x, float y) => new(x * 0.01666666667f, y * 0.01666666667f);
    public static AngleAccel2 MinuteDegreesPerSecond2(Vector2 v) => new(v.x * 0.01666666667f, v.y * 0.01666666667f);

    public Vector2 ToMinuteDegreesPerSecondsPerMinute() => new(x * 3600f, y * 3600f);
    public static AngleAccel2 MinuteDegreesPerSecondsPerMinute(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleAccel2 MinuteDegreesPerSecondsPerMinute(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMinuteDegreesPerSecondsPerHour() => new(x * 216000f, y * 216000f);
    public static AngleAccel2 MinuteDegreesPerSecondsPerHour(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleAccel2 MinuteDegreesPerSecondsPerHour(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToMinuteDegreesPerMinutesPerMicrosecond() => new(x * 0.0036f, y * 0.0036f);
    public static AngleAccel2 MinuteDegreesPerMinutesPerMicrosecond(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static AngleAccel2 MinuteDegreesPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToMinuteDegreesPerMinutesPerMillisecond() => new(x * 3.6f, y * 3.6f);
    public static AngleAccel2 MinuteDegreesPerMinutesPerMillisecond(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static AngleAccel2 MinuteDegreesPerMinutesPerMillisecond(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToMinuteDegreesPerMinutesPerSecond() => new(x * 3600f, y * 3600f);
    public static AngleAccel2 MinuteDegreesPerMinutesPerSecond(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleAccel2 MinuteDegreesPerMinutesPerSecond(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToMinuteDegreesPerMinute2() => new(x * 216000f, y * 216000f);
    public static AngleAccel2 MinuteDegreesPerMinute2(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleAccel2 MinuteDegreesPerMinute2(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToMinuteDegreesPerMinutesPerHour() => new(x * 12960000f, y * 12960000f);
    public static AngleAccel2 MinuteDegreesPerMinutesPerHour(float x, float y) => new(x * 7.716049383E-08f, y * 7.716049383E-08f);
    public static AngleAccel2 MinuteDegreesPerMinutesPerHour(Vector2 v) => new(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f);

    public Vector2 ToMinuteDegreesPerHoursPerMicrosecond() => new(x * 0.216f, y * 0.216f);
    public static AngleAccel2 MinuteDegreesPerHoursPerMicrosecond(float x, float y) => new(x * 4.62962963f, y * 4.62962963f);
    public static AngleAccel2 MinuteDegreesPerHoursPerMicrosecond(Vector2 v) => new(v.x * 4.62962963f, v.y * 4.62962963f);

    public Vector2 ToMinuteDegreesPerHoursPerMillisecond() => new(x * 216f, y * 216f);
    public static AngleAccel2 MinuteDegreesPerHoursPerMillisecond(float x, float y) => new(x * 0.00462962963f, y * 0.00462962963f);
    public static AngleAccel2 MinuteDegreesPerHoursPerMillisecond(Vector2 v) => new(v.x * 0.00462962963f, v.y * 0.00462962963f);

    public Vector2 ToMinuteDegreesPerHoursPerSecond() => new(x * 216000f, y * 216000f);
    public static AngleAccel2 MinuteDegreesPerHoursPerSecond(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleAccel2 MinuteDegreesPerHoursPerSecond(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToMinuteDegreesPerHoursPerMinute() => new(x * 12960000f, y * 12960000f);
    public static AngleAccel2 MinuteDegreesPerHoursPerMinute(float x, float y) => new(x * 7.716049383E-08f, y * 7.716049383E-08f);
    public static AngleAccel2 MinuteDegreesPerHoursPerMinute(Vector2 v) => new(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f);

    public Vector2 ToMinuteDegreesPerHour2() => new(x * 777600000f, y * 777600000f);
    public static AngleAccel2 MinuteDegreesPerHour2(float x, float y) => new(x * 1.28600823E-09f, y * 1.28600823E-09f);
    public static AngleAccel2 MinuteDegreesPerHour2(Vector2 v) => new(v.x * 1.28600823E-09f, v.y * 1.28600823E-09f);

    public Vector2 ToSecondDegreesPerMicrosecond2() => new(x * 3.6E-09f, y * 3.6E-09f);
    public static AngleAccel2 SecondDegreesPerMicrosecond2(float x, float y) => new(x * 277777777.8f, y * 277777777.8f);
    public static AngleAccel2 SecondDegreesPerMicrosecond2(Vector2 v) => new(v.x * 277777777.8f, v.y * 277777777.8f);

    public Vector2 ToSecondDegreesPerMicrosecondsPerMillisecond() => new(x * 3.6E-06f, y * 3.6E-06f);
    public static AngleAccel2 SecondDegreesPerMicrosecondsPerMillisecond(float x, float y) => new(x * 277777.7778f, y * 277777.7778f);
    public static AngleAccel2 SecondDegreesPerMicrosecondsPerMillisecond(Vector2 v) => new(v.x * 277777.7778f, v.y * 277777.7778f);

    public Vector2 ToSecondDegreesPerMicrosecondsPerSecond() => new(x * 0.0036f, y * 0.0036f);
    public static AngleAccel2 SecondDegreesPerMicrosecondsPerSecond(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static AngleAccel2 SecondDegreesPerMicrosecondsPerSecond(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToSecondDegreesPerMicrosecondsPerMinute() => new(x * 0.216f, y * 0.216f);
    public static AngleAccel2 SecondDegreesPerMicrosecondsPerMinute(float x, float y) => new(x * 4.62962963f, y * 4.62962963f);
    public static AngleAccel2 SecondDegreesPerMicrosecondsPerMinute(Vector2 v) => new(v.x * 4.62962963f, v.y * 4.62962963f);

    public Vector2 ToSecondDegreesPerMicrosecondsPerHour() => new(x * 12.96f, y * 12.96f);
    public static AngleAccel2 SecondDegreesPerMicrosecondsPerHour(float x, float y) => new(x * 0.07716049383f, y * 0.07716049383f);
    public static AngleAccel2 SecondDegreesPerMicrosecondsPerHour(Vector2 v) => new(v.x * 0.07716049383f, v.y * 0.07716049383f);

    public Vector2 ToSecondDegreesPerMillisecondsPerMicrosecond() => new(x * 3.6E-06f, y * 3.6E-06f);
    public static AngleAccel2 SecondDegreesPerMillisecondsPerMicrosecond(float x, float y) => new(x * 277777.7778f, y * 277777.7778f);
    public static AngleAccel2 SecondDegreesPerMillisecondsPerMicrosecond(Vector2 v) => new(v.x * 277777.7778f, v.y * 277777.7778f);

    public Vector2 ToSecondDegreesPerMillisecond2() => new(x * 0.0036f, y * 0.0036f);
    public static AngleAccel2 SecondDegreesPerMillisecond2(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static AngleAccel2 SecondDegreesPerMillisecond2(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToSecondDegreesPerMillisecondsPerSecond() => new(x * 3.6f, y * 3.6f);
    public static AngleAccel2 SecondDegreesPerMillisecondsPerSecond(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static AngleAccel2 SecondDegreesPerMillisecondsPerSecond(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToSecondDegreesPerMillisecondsPerMinute() => new(x * 216f, y * 216f);
    public static AngleAccel2 SecondDegreesPerMillisecondsPerMinute(float x, float y) => new(x * 0.00462962963f, y * 0.00462962963f);
    public static AngleAccel2 SecondDegreesPerMillisecondsPerMinute(Vector2 v) => new(v.x * 0.00462962963f, v.y * 0.00462962963f);

    public Vector2 ToSecondDegreesPerMillisecondsPerHour() => new(x * 12960f, y * 12960f);
    public static AngleAccel2 SecondDegreesPerMillisecondsPerHour(float x, float y) => new(x * 7.716049383E-05f, y * 7.716049383E-05f);
    public static AngleAccel2 SecondDegreesPerMillisecondsPerHour(Vector2 v) => new(v.x * 7.716049383E-05f, v.y * 7.716049383E-05f);

    public Vector2 ToSecondDegreesPerSecondsPerMicrosecond() => new(x * 0.0036f, y * 0.0036f);
    public static AngleAccel2 SecondDegreesPerSecondsPerMicrosecond(float x, float y) => new(x * 277.7777778f, y * 277.7777778f);
    public static AngleAccel2 SecondDegreesPerSecondsPerMicrosecond(Vector2 v) => new(v.x * 277.7777778f, v.y * 277.7777778f);

    public Vector2 ToSecondDegreesPerSecondsPerMillisecond() => new(x * 3.6f, y * 3.6f);
    public static AngleAccel2 SecondDegreesPerSecondsPerMillisecond(float x, float y) => new(x * 0.2777777778f, y * 0.2777777778f);
    public static AngleAccel2 SecondDegreesPerSecondsPerMillisecond(Vector2 v) => new(v.x * 0.2777777778f, v.y * 0.2777777778f);

    public Vector2 ToSecondDegreesPerSecond2() => new(x * 3600f, y * 3600f);
    public static AngleAccel2 SecondDegreesPerSecond2(float x, float y) => new(x * 0.0002777777778f, y * 0.0002777777778f);
    public static AngleAccel2 SecondDegreesPerSecond2(Vector2 v) => new(v.x * 0.0002777777778f, v.y * 0.0002777777778f);

    public Vector2 ToSecondDegreesPerSecondsPerMinute() => new(x * 216000f, y * 216000f);
    public static AngleAccel2 SecondDegreesPerSecondsPerMinute(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleAccel2 SecondDegreesPerSecondsPerMinute(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToSecondDegreesPerSecondsPerHour() => new(x * 12960000f, y * 12960000f);
    public static AngleAccel2 SecondDegreesPerSecondsPerHour(float x, float y) => new(x * 7.716049383E-08f, y * 7.716049383E-08f);
    public static AngleAccel2 SecondDegreesPerSecondsPerHour(Vector2 v) => new(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f);

    public Vector2 ToSecondDegreesPerMinutesPerMicrosecond() => new(x * 0.216f, y * 0.216f);
    public static AngleAccel2 SecondDegreesPerMinutesPerMicrosecond(float x, float y) => new(x * 4.62962963f, y * 4.62962963f);
    public static AngleAccel2 SecondDegreesPerMinutesPerMicrosecond(Vector2 v) => new(v.x * 4.62962963f, v.y * 4.62962963f);

    public Vector2 ToSecondDegreesPerMinutesPerMillisecond() => new(x * 216f, y * 216f);
    public static AngleAccel2 SecondDegreesPerMinutesPerMillisecond(float x, float y) => new(x * 0.00462962963f, y * 0.00462962963f);
    public static AngleAccel2 SecondDegreesPerMinutesPerMillisecond(Vector2 v) => new(v.x * 0.00462962963f, v.y * 0.00462962963f);

    public Vector2 ToSecondDegreesPerMinutesPerSecond() => new(x * 216000f, y * 216000f);
    public static AngleAccel2 SecondDegreesPerMinutesPerSecond(float x, float y) => new(x * 4.62962963E-06f, y * 4.62962963E-06f);
    public static AngleAccel2 SecondDegreesPerMinutesPerSecond(Vector2 v) => new(v.x * 4.62962963E-06f, v.y * 4.62962963E-06f);

    public Vector2 ToSecondDegreesPerMinute2() => new(x * 12960000f, y * 12960000f);
    public static AngleAccel2 SecondDegreesPerMinute2(float x, float y) => new(x * 7.716049383E-08f, y * 7.716049383E-08f);
    public static AngleAccel2 SecondDegreesPerMinute2(Vector2 v) => new(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f);

    public Vector2 ToSecondDegreesPerMinutesPerHour() => new(x * 777600000f, y * 777600000f);
    public static AngleAccel2 SecondDegreesPerMinutesPerHour(float x, float y) => new(x * 1.28600823E-09f, y * 1.28600823E-09f);
    public static AngleAccel2 SecondDegreesPerMinutesPerHour(Vector2 v) => new(v.x * 1.28600823E-09f, v.y * 1.28600823E-09f);

    public Vector2 ToSecondDegreesPerHoursPerMicrosecond() => new(x * 12.96f, y * 12.96f);
    public static AngleAccel2 SecondDegreesPerHoursPerMicrosecond(float x, float y) => new(x * 0.07716049383f, y * 0.07716049383f);
    public static AngleAccel2 SecondDegreesPerHoursPerMicrosecond(Vector2 v) => new(v.x * 0.07716049383f, v.y * 0.07716049383f);

    public Vector2 ToSecondDegreesPerHoursPerMillisecond() => new(x * 12960f, y * 12960f);
    public static AngleAccel2 SecondDegreesPerHoursPerMillisecond(float x, float y) => new(x * 7.716049383E-05f, y * 7.716049383E-05f);
    public static AngleAccel2 SecondDegreesPerHoursPerMillisecond(Vector2 v) => new(v.x * 7.716049383E-05f, v.y * 7.716049383E-05f);

    public Vector2 ToSecondDegreesPerHoursPerSecond() => new(x * 12960000f, y * 12960000f);
    public static AngleAccel2 SecondDegreesPerHoursPerSecond(float x, float y) => new(x * 7.716049383E-08f, y * 7.716049383E-08f);
    public static AngleAccel2 SecondDegreesPerHoursPerSecond(Vector2 v) => new(v.x * 7.716049383E-08f, v.y * 7.716049383E-08f);

    public Vector2 ToSecondDegreesPerHoursPerMinute() => new(x * 777600000f, y * 777600000f);
    public static AngleAccel2 SecondDegreesPerHoursPerMinute(float x, float y) => new(x * 1.28600823E-09f, y * 1.28600823E-09f);
    public static AngleAccel2 SecondDegreesPerHoursPerMinute(Vector2 v) => new(v.x * 1.28600823E-09f, v.y * 1.28600823E-09f);

    public Vector2 ToSecondDegreesPerHour2() => new(x * 4.6656E+10f, y * 4.6656E+10f);
    public static AngleAccel2 SecondDegreesPerHour2(float x, float y) => new(x * 2.143347051E-11f, y * 2.143347051E-11f);
    public static AngleAccel2 SecondDegreesPerHour2(Vector2 v) => new(v.x * 2.143347051E-11f, v.y * 2.143347051E-11f);

    public Vector2 ToMillinewtonsPerMilligram() => new(x * 1000000000f, y * 1000000000f);
    public static AngleAccel2 MillinewtonsPerMilligram(float x, float y) => new(x * 1E-09f, y * 1E-09f);
    public static AngleAccel2 MillinewtonsPerMilligram(Vector2 v) => new(v.x * 1E-09f, v.y * 1E-09f);

    public Vector2 ToMillinewtonsPerGram() => new(x * 1000000f, y * 1000000f);
    public static AngleAccel2 MillinewtonsPerGram(float x, float y) => new(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 MillinewtonsPerGram(Vector2 v) => new(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToMillinewtonsPerKilogram() => new(x * 1000f, y * 1000f);
    public static AngleAccel2 MillinewtonsPerKilogram(float x, float y) => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 MillinewtonsPerKilogram(Vector2 v) => new(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToMillinewtonsPerTon() => new(x * 1f, y * 1f);
    public static AngleAccel2 MillinewtonsPerTon(float x, float y) => new(x * 1f, y * 1f);
    public static AngleAccel2 MillinewtonsPerTon(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToMillinewtonsPerKiloton() => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 MillinewtonsPerKiloton(float x, float y) => new(x * 1000f, y * 1000f);
    public static AngleAccel2 MillinewtonsPerKiloton(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerMilligram() => new(x * 1000000f, y * 1000000f);
    public static AngleAccel2 NewtonsPerMilligram(float x, float y) => new(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 NewtonsPerMilligram(Vector2 v) => new(v.x * 1E-06f, v.y * 1E-06f);

    public Vector2 ToNewtonsPerGram() => new(x * 1000f, y * 1000f);
    public static AngleAccel2 NewtonsPerGram(float x, float y) => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 NewtonsPerGram(Vector2 v) => new(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToNewtonsPerKilogram() => new(x * 1f, y * 1f);
    public static AngleAccel2 NewtonsPerKilogram(float x, float y) => new(x * 1f, y * 1f);
    public static AngleAccel2 NewtonsPerKilogram(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToNewtonsPerTon() => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 NewtonsPerTon(float x, float y) => new(x * 1000f, y * 1000f);
    public static AngleAccel2 NewtonsPerTon(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToNewtonsPerKiloton() => new(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 NewtonsPerKiloton(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static AngleAccel2 NewtonsPerKiloton(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerMilligram() => new(x * 1000f, y * 1000f);
    public static AngleAccel2 KilonewtonsPerMilligram(float x, float y) => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 KilonewtonsPerMilligram(Vector2 v) => new(v.x * 0.001f, v.y * 0.001f);

    public Vector2 ToKilonewtonsPerGram() => new(x * 1f, y * 1f);
    public static AngleAccel2 KilonewtonsPerGram(float x, float y) => new(x * 1f, y * 1f);
    public static AngleAccel2 KilonewtonsPerGram(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToKilonewtonsPerKilogram() => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 KilonewtonsPerKilogram(float x, float y) => new(x * 1000f, y * 1000f);
    public static AngleAccel2 KilonewtonsPerKilogram(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToKilonewtonsPerTon() => new(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 KilonewtonsPerTon(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static AngleAccel2 KilonewtonsPerTon(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToKilonewtonsPerKiloton() => new(x * 1E-09f, y * 1E-09f);
    public static AngleAccel2 KilonewtonsPerKiloton(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static AngleAccel2 KilonewtonsPerKiloton(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerMilligram() => new(x * 1f, y * 1f);
    public static AngleAccel2 MeganewtonsPerMilligram(float x, float y) => new(x * 1f, y * 1f);
    public static AngleAccel2 MeganewtonsPerMilligram(Vector2 v) => new(v.x * 1f, v.y * 1f);

    public Vector2 ToMeganewtonsPerGram() => new(x * 0.001f, y * 0.001f);
    public static AngleAccel2 MeganewtonsPerGram(float x, float y) => new(x * 1000f, y * 1000f);
    public static AngleAccel2 MeganewtonsPerGram(Vector2 v) => new(v.x * 1000f, v.y * 1000f);

    public Vector2 ToMeganewtonsPerKilogram() => new(x * 1E-06f, y * 1E-06f);
    public static AngleAccel2 MeganewtonsPerKilogram(float x, float y) => new(x * 1000000f, y * 1000000f);
    public static AngleAccel2 MeganewtonsPerKilogram(Vector2 v) => new(v.x * 1000000f, v.y * 1000000f);

    public Vector2 ToMeganewtonsPerTon() => new(x * 1E-09f, y * 1E-09f);
    public static AngleAccel2 MeganewtonsPerTon(float x, float y) => new(x * 1000000000f, y * 1000000000f);
    public static AngleAccel2 MeganewtonsPerTon(Vector2 v) => new(v.x * 1000000000f, v.y * 1000000000f);

    public Vector2 ToMeganewtonsPerKiloton() => new(x * 1E-12f, y * 1E-12f);
    public static AngleAccel2 MeganewtonsPerKiloton(float x, float y) => new(x * 1E+12f, y * 1E+12f);
    public static AngleAccel2 MeganewtonsPerKiloton(Vector2 v) => new(v.x * 1E+12f, v.y * 1E+12f);

    public static AngleAccel2 operator +(AngleAccel2 a, AngleAccel2 b) => new(a.x + b.x, a.y + b.y);
    public static AngleAccel2 operator -(AngleAccel2 a, AngleAccel2 b) => new(a.x - b.x, a.y - b.y);
    
    public static AngleAccel2 operator *(AngleAccel2 a, AngleAccel2 b) => new(a.x * b.x, a.y * b.y);
    public static AngleAccel2 operator /(AngleAccel2 a, AngleAccel2 b) => new(a.x / b.x, a.y / b.y);
    
    public AngleVel2 AngleVel2(Time v) => new(v * x, v * y);
    public Time Time(AngleVel2 v) => new(v.magnitude / magnitude);

    public AngleAccel2(AngleVel2 a, Time b) : this(a.AngleAccel2(b)) { }
    public AngleAccel2(Time b, AngleVel2 a) : this(a.AngleAccel2(b)) { }

    public Torque2 Torque2(Mass v) => new(v * x, v * y);
    public Mass Mass(Torque2 v) => new(v.magnitude / magnitude);

    public AngleAccel2(Torque2 a, Mass b) : this(a.AngleAccel2(b)) { }
    public AngleAccel2(Mass b, Torque2 a) : this(a.AngleAccel2(b)) { }

}
}

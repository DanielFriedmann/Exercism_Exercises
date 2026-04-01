using System.Globalization;
using System.Runtime.InteropServices;
public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();


    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        DateTime parsed = DateTime.Parse(appointmentDateDescription);
        DateTime unspecified = DateTime.SpecifyKind(parsed, DateTimeKind.Unspecified);

        TimeZoneInfo zone = GetTzInfo(location);

        return TimeZoneInfo.ConvertTimeToUtc(unspecified, zone);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        switch (alertLevel)
        {
            case AlertLevel.Early: return appointment.AddDays(-1);
            case AlertLevel.Standard: return appointment.AddHours(-1.75);
            case AlertLevel.Late: return appointment.AddMinutes(-30);
            default: return appointment;
        }
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        TimeZoneInfo zone = GetTzInfo(location);

        DateTime sevendays = dt.AddDays(-7);

        return zone.IsDaylightSavingTime(sevendays) || zone.IsDaylightSavingTime(dt);
    }


    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo culture;

        switch (location)
        {
            case Location.NewYork:
                culture = new CultureInfo("en-US");
                break;
            case Location.Paris:
                culture = new CultureInfo("fr-FR");
                break;
            case Location.London:
                culture = new CultureInfo("en-GB");
                break;
            default:
                return new DateTime();
        }

        if (DateTime.TryParse(dtStr, culture, DateTimeStyles.None, out DateTime result))
        {
            return result;
        }

        return new DateTime();
    }
    public static TimeZoneInfo GetTzInfo(Location location)
    {
        TimeZoneInfo zone;
        switch (location)
        {
            case Location.NewYork:
                zone = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                    ? TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")
                    : TimeZoneInfo.FindSystemTimeZoneById("America/New_York");
                break;

            case Location.Paris:
                zone = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                    ? TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time")
                    : TimeZoneInfo.FindSystemTimeZoneById("Europe/Paris");
                break;

            case Location.London:
                zone = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                    ? TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")
                    : TimeZoneInfo.FindSystemTimeZoneById("Europe/London");
                break;

            default:
                throw new ArgumentException("Unknown location");
        }

        return zone;
    }
}

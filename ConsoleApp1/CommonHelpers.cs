namespace ConsoleApp1;


public static class CommonHelpers
{
    public static string GetSeason(int month) => $"The season is {(month switch
    {
        1 or 2 or 12 => "winter",
        > 2 and < 6 => "spring",
        > 5 and < 9 => "summer",
        > 8 and < 12 => "autumn",
        _ => "unknown."
    })}.";

    public static string CurrentSeason => GetSeason(DateTime.Now.Month);
}

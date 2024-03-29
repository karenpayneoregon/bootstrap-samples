﻿namespace BootstrapInputGroupValidateExample.Classes;

public static partial class Extensions
{
    /// <summary>
    /// Mask SSN
    /// </summary>
    /// <param name="ssn">Valid SSN</param>
    /// <param name="digitsToShow">How many digits to show on right which defaults to 4</param>
    /// <param name="maskCharacter">Character to mask with which defaults to X</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static string MaskSsn(this string ssn, int digitsToShow = 4, char maskCharacter = 'X')
    {
        if (string.IsNullOrWhiteSpace(ssn)) return string.Empty;
        if (ssn.Contains("-")) ssn = ssn.Replace("-", string.Empty);
        if (ssn.Length != 9) throw new ArgumentException("SSN invalid length");
        if (ssn.IsNotInteger()) throw new ArgumentException("SSN not valid");

        const int ssnLength = 9;
        const string separator = "-";
        int maskLength = ssnLength - digitsToShow;

        int output = int.Parse(ssn.Replace(separator, string.Empty).Substring(maskLength, digitsToShow));

        string format = string.Empty;
        for (int index = 0; index < maskLength; index++) format += maskCharacter;
        for (int index = 0; index < digitsToShow; index++) format += "0";

        format = format.Insert(3, separator).Insert(6, separator);
        format = $"{{0:{format}}}";

        return string.Format(format, output);
    }
    public static bool IsInteger(this string sender)
    {
        foreach (var c in sender)
            if (c is < '0' or > '9') return false;

        return true;
    }

    public static bool IsNotInteger(this string sender)
        => sender.IsInteger() == false;

    public static string RemoveStartAndEndQuotes(this string sender)
        => (sender?.Length ?? 0) < 2
            ? sender
            : sender!.Length > 1 && (sender[0] == '"' && sender[^1] == '"' || sender[0] == '\'' && sender[^1] == '\'')
                ? sender.Substring(1, sender.Length - 2)
                : sender;
}

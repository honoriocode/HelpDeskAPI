namespace HelpDeskApi.Domain.Helpers;

public static class StringExtensions
{
    public static bool HasCorrectLength(this string text, int min, int max)
        => text.Length >= min && text.Length <= max;

    public static bool HasUpperCase(this string text)
        => text.Any(char.IsUpper);

    public static bool HasLowerCase(this string text)
        => text.Any(char.IsLower);

    public static bool HasNumber(this string text)
        => text.Any(char.IsNumber);

    public static bool HasSpecialChar(this string text)
        => text.Any(c => char.IsPunctuation(c) || char.IsSymbol(c));

    public static bool IsNumber(this string text)
        => text.All(char.IsNumber);

    public static bool IsEmpty(this string text)
        => string.IsNullOrEmpty(text)
        || string.IsNullOrWhiteSpace(text);
}
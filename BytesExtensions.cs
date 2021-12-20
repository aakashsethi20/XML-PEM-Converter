namespace XmlPemConverter;

public static class BytesExtensions
{
    public static string ToBase64(this byte[] bytes)
    {
        return Convert.ToBase64String(bytes);
    }
}

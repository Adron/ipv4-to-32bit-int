namespace IpConverter;

public static class IpConvert
{
    public static uint ToInt32(string ip)
    {
        return ip.Split('.')
            .Select(octet => Convert.ToUInt32(octet))
            .Aggregate((result, octet) => (result << 8) + octet);
    }
}
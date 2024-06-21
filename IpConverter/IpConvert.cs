namespace IpConverter;

public static class IpConvert
{
    public static uint ToInt32(string ip)
    {
        return ip.Split('.')
            .Select(octet => Convert.ToUInt32(octet))
            .Aggregate((result, octet) => (result << 8) + octet);
    }
    
    public static uint AddressBlock(string ipAddress)
    {
        var parts = ipAddress.Split('/');
        var mask = int.Parse(parts[1]);

        // Calculate total addresses in the block
        var totalAddresses = (uint)Math.Pow(2, 32 - mask);

        return totalAddresses;
    }
    
    public static uint UsableAddresses(string ipAddress)
    {
        return AddressBlock(ipAddress) - 2;
    }
}
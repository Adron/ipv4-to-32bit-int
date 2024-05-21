namespace IpConverter;

public static class IpConvert
{
    public static uint ToInt32(string ip)
    {
        string[] octets = ip.Split('.');
        uint ipNumber = 0;

        ipNumber += Convert.ToUInt32(octets[0]) << 24; // Shift the first octet left by 24 bits
        ipNumber += Convert.ToUInt32(octets[1]) << 16; // Shift the second octet left by 16 bits
        ipNumber += Convert.ToUInt32(octets[2]) << 8;  // Shift the third octet left by 8 bits
        ipNumber += Convert.ToUInt32(octets[3]);       // Fourth octet stays as is

        return ipNumber;
    }
}
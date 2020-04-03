public class T
{
    public const byte ENQ = 5;
    public const byte ACK = 6;
    public const byte NAK = 21;
    public const byte EOT = 4;
    public const byte ETX = 3;
    public const byte ETB = 23;
    public const byte STX = 2;
    public const byte NEWLINE = 10;
    public static byte[] ACK_BUFF = { ACK };
    public static byte[] ENQ_BUFF = { ENQ };
    public static byte[] NAK_BUFF = { NAK };
    public static byte[] EOT_BUFF = { EOT };
}

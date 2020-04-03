/// <summary>
/// include the Class T
/// Reads checksum of an ASTM frame, calculates characters after STX,
/// up to and including the ETX or ETB. Method assumes the frame contains an ETX or ETB.
/// </summary>
/// <param name="frame">frame of ASTM data to evaluate</param>
/// <returns>string containing checksum</returns>
public string GetCheckSumValue(string frame)
{
    string checksum = "00";

    int byteVal = 0;
    int sumOfChars = 0;
    bool complete = false;
    
    //take each byte in the string and add the values
    for (int idx = 0; idx < frame.Length; idx++)
    {
        byteVal = Convert.ToInt32(frame[idx]);
        
        switch (byteVal)
        {
            case T.STX:
                sumOfChars = 0;
                break;
            case T.ETX:
            case T.ETB:
                sumOfChars += byteVal;
                complete = true;
                break;
            default:
                sumOfChars += byteVal;
                break;
        }

        if (complete)
            break;
    }

    if (sumOfChars > 0)
    {
        //hex value mod 256 is checksum, return as hex value in upper case
        checksum = Convert.ToString(sumOfChars % 256, 16).ToUpper();
    }
    
    //if checksum is only 1 char then prepend a 0
    return (string)(checksum.Length == 1 ? "0" + checksum : checksum);
}

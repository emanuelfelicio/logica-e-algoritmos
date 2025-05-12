
string hour = "09:05:45AM";

Console.WriteLine(timeConversion(hour));
static string timeConversion(string s)
{
    // 12pm == 12 ; 12am == 00
    if (s[8..] == "PM" && s[..2] != "12")
    {
        s = (12 + Convert.ToInt32(s[..2])).ToString() + s[2..];
    }
    if (s[8..] == "AM" && s[..2] != "12")
    {
        s = s[..8];
    }
    if (s[..2] == "12")
    {
        if (s[8..] == "AM")
        {
            s = "00" + s.Substring(2, 6);
        }
        else
        {
            s = s[..8];
        }
    }

    return s;
}
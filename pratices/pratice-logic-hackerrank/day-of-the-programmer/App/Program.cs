
class Result
{

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        bool julianCalendar = false;
        bool gregorianCalendar = false;
        bool year1918 = false;
        int programmerDay = 256;

        if (year == 1918)
        {
            year1918 = true;
        }
        else if (year > 1918)
        {
            gregorianCalendar = true;
        }
        else
        {
            julianCalendar = true;
        }

        int month = 1;
        int day = 0;

        while (programmerDay >= 28)
        {

            if (month == 2)
            {
                if (julianCalendar)
                {
                    if (year % 4 == 0)
                    {
                        programmerDay -= 29;

                    }
                    else
                    {
                        programmerDay -= 28;

                    }
                }
                else if (gregorianCalendar)
                {
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        programmerDay -= 29;

                    }
                    else
                    {
                        programmerDay -= 28;

                    }
                }
                else if (year1918)
                {
                    programmerDay -= 15;
                }

            }

            else if (month % 2 != 0)
            {
                if (month >= 9)
                {
                    programmerDay -= 30;
                }

                else
                {
                    programmerDay -= 31;
                }
            }

            else if (month % 2 == 0)

            {
                if (month >= 8)
                {
                    programmerDay -= 31;
                }
                else
                {
                    programmerDay -= 30;
                }
            }

            month++;
            day = programmerDay;
        }
        return $"{day:D2}.{month:D2}.{year:D4}";
    }

}
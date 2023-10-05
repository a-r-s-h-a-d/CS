// class EnumExample
// {
//     enum Level
//         {
//             Low,
//             Medium,
//             High
//         }
//     public static void Main()
//     {
//         Level myLevel =  Level.Medium;
//         Console.WriteLine(myLevel);
//     }
// }


class EnumExampleWithSwitch
{
    enum Level
    {
        Easy,
        Medium,
        High
    }

    public static void Main()
    {
        Level myLevel = Level.Medium;

        switch (myLevel)
        {
            case Level.Easy:
            Console.WriteLine("Low level");
            break;

            case Level.Medium:
            Console.WriteLine("Medium Level");
            break;

            case Level.High:
            Console.WriteLine("High Level");
            break;
            
            default:
            Console.WriteLine("Something Went Wrong");
            break;
        }
    }
}
namespace labuppigft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "367835215";
            var SliceNumber = input[0];
            var ranges= new List<string>();
            var start = 0;
             
            for (var index=0;index < input.Length; index++)
            {
                var current = input[index];
                if (! char.IsNumber(current))
                    Console.WriteLine( "Invaild input! ");
                if (current == SliceNumber && index != 0)
                {
                    ranges.Add(input[start..(index+1)]);
                    if (index+1>=input.Length)
                        break;
                    SliceNumber= input[++index];
                    start = index;



                }
            }
            var total = 0;
            foreach (var number in ranges)
                total+=int.Parse(number);
            Console.WriteLine(total);
        }
    }
}
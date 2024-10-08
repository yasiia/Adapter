namespace Adapter
{
    namespace Adapter
    {
        internal class Program
        {
            public class Round
            {
                public int radius;
                public Round(int radius)
                {
                    this.radius = radius;
                }
                
            }

            public interface ISquare
            {
                int GetSide(Round round);
            }
            
            public class MakeSquareAdapter : ISquare
            {
                private  Round round;

                public MakeSquareAdapter(Round round)
                {
                    round = round;
                }

                
                public int GetSide(Round round)
                {
                    return round.radius * 2;
                }
            }

            static void Main(string[] args)
            {
                
                Round round = new Round(10);
                round.radius = 10;
                
                ISquare square = new MakeSquareAdapter(round);

                
                Console.WriteLine($"Square side: {square.GetSide(round)}");
            }
        }
    }
}


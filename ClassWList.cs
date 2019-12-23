public class Program

{

                public class helix

                {

                                public List<int> parts = new List<int>();

                }

               

                public static void Main()

                {

                                //List<helix> parts = new List<helix>();

                                helix piece = new helix();

                                piece.parts.Add(3);

                                Console.WriteLine("Hello World" + piece.parts[0]);

                }

}

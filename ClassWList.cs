using System;

using System.Collections.Generic;

                                                                               

public class Program

{

               

                public class helix

                {

                                public int height { get; set; }

                                public List<int> parts = new List<int>();

                               

                                public int first()

                                {

                                                return this.parts[0];

                                }

                }

               

                public static void Main()

                {

                                //List<helix> parts = new List<helix>();

                                List<int> addme = new List<int>();

                                addme.Add(1);

                                addme.Add(3);

                                addme.Add(4);

                                helix piece = new helix();

                                piece.parts = addme;

                                piece.height = 4;

                                piece.parts.Add(3);

                                Console.WriteLine("Hello World " + piece.first());

                }

}

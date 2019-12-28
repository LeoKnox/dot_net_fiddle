using System;

                                                                               

public class Program

{

                public class Room

                {

                                public int width;

                                public int height;

                               

                                public Room MakeRoom()

                                {

                                                Room test = new Room();

                                                test.width = 3;

                                                test.height = 4;

                                                return test;

                                }

                }

                public static void Main()

                {

                                Room first = new Room();

                                Console.WriteLine("Hello World {0}", first.MakeRoom().width);

                }

}


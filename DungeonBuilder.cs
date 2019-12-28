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

                public class Hall

                {

                                public int length;

                                public int width;

                                public int? breaks;

                               

                                public Hall(int l, int w, int? b)

                                {

                                                this.length = l;

                                                this.width = w;

                                                this.breaks = b;

                                }

                }

                public static void Main()

                {

                                Room first = new Room();

                                Hall fway = new Hall(5, 2, 3);

                                Console.WriteLine("Hello World {0}", first.MakeRoom().width);

                                Console.WriteLine("Hall {0} - {1} - {2}", fway.length, fway.width, fway.breaks);

                }

}

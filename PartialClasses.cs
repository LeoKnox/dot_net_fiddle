using System;

using System.Collections.Generic;

                                                                               

public class Program

{

                public class Box

                {

                                public int h;

                                public int w;

                               

                                public Box(int h, int w)

                                {

                                                this.h = h;

                                                this.w = w;

                                }

                }

               

                public class Widge

                {

                                public string f;

                                public string l;

                               

                                public Widge(string f, string l)

                                {

                                                this.f = f;

                                                this.l = l;

                                }

                }

                public static void Main()

                {

                                List<object> test = new List<object>();

                                test.Add("string");

                                Console.WriteLine("Hello World");

                }

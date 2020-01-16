using System;

using System.Collections.Generic;

                                                                               

public class Program

{

                public class Scabs

                {

                                public int Fee { get; set; }

                                public int Fi { get; set; }

                               

                                public Scabs(int fe, int fi)

                                {

                                                this.Fee = fe;

                                                this.Fi = fi;

                                }

                }

               

                public static void Main()

                {

                                Scabs Ran = new Scabs(3, 4);

                                Dictionary<string, Scabs> Weird = new Dictionary<string, Scabs>();

                                Weird["Red"] = Ran;

                                Console.WriteLine("Hello World " + Weird["Red"].Fee);

                }

}

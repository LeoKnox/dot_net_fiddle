model
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldMvcApp
{
public class Room
{
public int Width { get; set; }
public int Height { get; set; }
public List<string> Mobs = new List<string>();

public void AddMob(string mob)
{
this.Mobs.Add(mob);
}
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level01Ingredient
{
    public string Name { get; set; }
    public string Category { get; set; }
    public string SizeUnit { get; set; }
    public int MinSize { get; set; }
    public int MaxSize { get; set; }
    public int MinPrice { get; set; }
    public int MaxPrice { get; set; }
    public string ModelName { get; set; }

    public override string ToString()
    {
        return Name;
    }
}

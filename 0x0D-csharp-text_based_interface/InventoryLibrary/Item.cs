using System;
using System.Collections;
using System.Collections.Generic;

///<summary>Item class which inherits from BaseClass</summary>
public class Item : BaseClass
{
    ///<summary>the items name</summary>
    public string name { get; set; }
    ///<summary>the items description</summary>
    public string description { get; set; }
    ///<summary>the price of the item</summary>
    public float price { get; set; }
    ///<summary>the tags the item fall under</summary>
    public List<string> tags { get; set; }

///<summary>item class constructor</summary>
    public Item(string name, string description = null, float price = 0, string[] tags = null)
    {
        this.name = name;
        this.description = description;
        if (price > 0)
            this.price = (float)Math.Round(price, 2);
        this.tags = tags;
    }
}
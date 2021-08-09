using System;

///<summary>Base clase for inventory management proj </summary>
    public class BaseClass
{
    ///<summary>ID of class object</summary>    
    public string id { get; set; }
    ///<summary>time and date that object was created </summary>
    public DateTime date_created { get; set; }
    ///<summary>time and date is set at creation and when upadted</summary>
    public DateTime date_updated { get; set; }

    ///<summary>constructor for BaseClass</summary>
    public BaseClass()
    {
        this.id = System.Guid.NewGuid().ToString();
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
}


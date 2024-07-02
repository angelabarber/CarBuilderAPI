namespace CarBuilderAPI.Models;

public class Order
{
    public  int Id {get; set;}

    public DateTime DateCompleted { get; set; }

    public int WheelId { get; set; }

    public int TechnologyId { get; set; }

    public int PaintColorId { get;set; }

    public int InteriorId { get;set; }

}
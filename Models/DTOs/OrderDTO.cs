namespace CarBuilderAPI.Models.DTOs;

public class OrderDTO
{
    public  int Id {get; set;}

    public DateTime Timestamp { get; set; }

    public int WheelId { get; set; }

    public int TechnologyId { get; set; }

    public int PaintColorId { get;set; }

    public int InteriorId { get;set; }

    public WheelDTO Wheel {get;set;}

    public TechnologyDTO Technology {get ; set;}

    public InteriorDTO Interior {get; set;}

    public PaintColorDTO PaintColor {get; set; }

    public decimal TotalCost => Wheel.Price + Technology.Price + PaintColor.Price + Interior.Price;
}
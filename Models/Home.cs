namespace gregslistesharp.Models;

public class Home
{
    public int Id { get; set; }
    public string Style { get; set; }
    public int? Year { get; set; }
    public int? SqFeet { get; set; }
    public double? Price { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }

    public bool Archived { get; set; }

    public string CreatorId { get; set; }

    public Account Creator { get; set; }
}
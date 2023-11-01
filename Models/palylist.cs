using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;


namespace WebApplication1.Models;

public class palylist
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public string TypeDescription { get; set; }
    public string DescriptionDescription { get; set; }
    public string TypeName { get; set; }

    public string TypeDescriptionDescription { get; set;}
}

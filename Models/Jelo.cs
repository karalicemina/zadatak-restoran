using System.ComponentModel.DataAnnotations;
namespace zadatak.Models;

public class Jelo
{
    public int Id{get; set;}
    [Required] public string Naziv{get ; set;}
    [Range(0.01, 100000)] public decimal Cijena{get;set ;}
    public int RestoranId{get;set;}

    public Restoran? Restoran { get; set; }

}
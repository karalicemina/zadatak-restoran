using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace zadatak.Models;

public class Restoran
{
    public int Id {get ; set; }
   [Required] public string Naziv{get ; set;}
   [Required] public string Adresa{get ; set;}
   [Required] public string Telefon{get ; set;}

}
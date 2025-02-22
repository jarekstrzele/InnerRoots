using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InnerRoots.Models;

public class Person
{
   public string Id { get; set; } = Guid.NewGuid().ToString();
   public string FirstName { get; set; }
   public string LastName { get; set; }
   
   public DateTime? Birthday { get; set; }
   public DateTime? Deathday { get; set; }
   
   public string Notes { get; set; }
   
   public List<Person> Children { get; set; } = new();
   
   
   
}
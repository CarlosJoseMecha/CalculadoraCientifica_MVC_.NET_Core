﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CalculadoraCientifica.Models;

public class ApplicationUser : IdentityUser
{
   public string? FirstName { get; set; }
   public string? LastName { get; set; }
   public ICollection<Operacion>? Operaciones { get; set; }
}


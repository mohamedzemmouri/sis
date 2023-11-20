﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIS.Infrastructure.EFRepository.Models;

public partial class Concept
{
    [Key]
    public int ConceptId { get; set; }

    public string? TableName { get; set; }

    public string? Description { get; set; }

    public DateTime AutoTimeCreation { get; set; }

    public DateTime AutoTimeUpdate { get; set; }

    public int AutoUpdateCount { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<Info> Infos { get; set; } = new List<Info>();
}

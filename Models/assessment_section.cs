﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace GetAsessmentAnswers.Models;

public partial class assessment_section
{
    public long id { get; set; }

    public string title { get; set; }

    public string description { get; set; }

    public long assessment_id { get; set; }

    public int order { get; set; }

    public DateTime? created_at { get; set; }

    public DateTime? updated_at { get; set; }

    public virtual assessment assessment { get; set; }
}
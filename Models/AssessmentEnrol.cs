﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace GetAsessmentAnswers.Models;

public partial class AssessmentEnrol
{
    public int enrol_id { get; set; }

    public int? userid { get; set; }

    public int? assessment_id { get; set; }

    public DateTime? enrolment_date { get; set; }

    public virtual Assessment assessment { get; set; }

    public virtual User user { get; set; }
}
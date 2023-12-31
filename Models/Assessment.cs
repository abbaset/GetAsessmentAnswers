﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace GetAsessmentAnswers.Models;

public partial class assessment
{
    public long id { get; set; }

    public string title { get; set; }

    public string short_description { get; set; }

    public string description { get; set; }

    public string slug { get; set; }

    public int? created_by { get; set; }

    public int? updated_by { get; set; }

    public int duration { get; set; }

    public long? category_id { get; set; }

    public string thumbnail { get; set; }

    public byte published { get; set; }

    public DateTime? created_at { get; set; }

    public DateTime? updated_at { get; set; }

    public virtual ICollection<assessment_answer> assessment_answers { get; set; } = new List<assessment_answer>();

    public virtual ICollection<assessment_datum> assessment_data { get; set; } = new List<assessment_datum>();

    public virtual ICollection<assessment_department> assessment_departments { get; set; } = new List<assessment_department>();

    public virtual ICollection<assessment_enrol> assessment_enrols { get; set; } = new List<assessment_enrol>();

    public virtual ICollection<assessment_metum> assessment_meta { get; set; } = new List<assessment_metum>();

    public virtual ICollection<assessment_questions_relation> assessment_questions_relations { get; set; } = new List<assessment_questions_relation>();

    public virtual ICollection<assessment_section> assessment_sections { get; set; } = new List<assessment_section>();
}
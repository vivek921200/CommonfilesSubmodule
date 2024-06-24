﻿using System;
using System.Collections.Generic;

namespace PiHire.DAL.Entities;

public partial class PhCandidateRecruitersHistory
{
    public int Id { get; set; }

    public int Joid { get; set; }

    public int CandProfId { get; set; }

    public int RecruiterId { get; set; }

    public int Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string Remarks { get; set; }
}

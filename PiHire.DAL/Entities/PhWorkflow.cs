﻿using System;
using System.Collections.Generic;

namespace PiHire.DAL.Entities;

public partial class PhWorkflow
{
    public short Id { get; set; }

    public short TaskId { get; set; }

    public string TaskCode { get; set; }

    public byte ActionMode { get; set; }

    public byte Status { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}

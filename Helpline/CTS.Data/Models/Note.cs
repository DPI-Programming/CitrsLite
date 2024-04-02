﻿using System;
using System.Collections.Generic;

namespace CTS.Data.Models;

public partial class Note
{
    public int Id { get; set; }

    public string? CallerRemarks { get; set; }

    public string? Comments { get; set; }

    public string? Resolution { get; set; }

    public int TicketId { get; set; }

    public string? CreatedByUserName { get; set; }

    public DateTime CreationDate { get; set; }

    public string? LastModifiedByUserName { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual Ticket Ticket { get; set; } = null!;
}
﻿using System.Collections.Generic;

namespace Shark.EntityFrameworkCore.Extensions;

public class BulkQueryResult
{
    public IEnumerable<object[]> Results { get; internal set; }
    public IEnumerable<string> Columns { get; internal set; }
    public int RowsAffected { get; internal set; }
}
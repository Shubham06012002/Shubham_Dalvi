using System;
using System.Collections.Generic;

namespace Shubham_Dalvi.Entities;

public partial class PersonalInfo
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Message { get; set; } = null!;
}

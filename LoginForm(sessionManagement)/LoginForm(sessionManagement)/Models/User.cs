﻿using System;
using System.Collections.Generic;

namespace LoginForm_sessionManagement_.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int Age { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}

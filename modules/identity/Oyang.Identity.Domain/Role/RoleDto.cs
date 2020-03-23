﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oyang.Identity.Domain.Role
{
    public class RoleDto : IDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

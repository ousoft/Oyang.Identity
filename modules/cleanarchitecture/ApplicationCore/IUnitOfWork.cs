﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}

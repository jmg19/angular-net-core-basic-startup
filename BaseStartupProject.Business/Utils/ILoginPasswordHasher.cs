﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaseStartupProject.Business.Utils
{
    public interface ILoginPasswordHasher
    {
        string GenerateUserHash(int id, string username, string password);
    }
}

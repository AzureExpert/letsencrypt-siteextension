﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsEncrypt.SiteExtension.Core.Models
{
    public interface IAuthorizationChallengeProviderConfig
    {
        bool DisableWebConfigUpdate { get; }
    }
}

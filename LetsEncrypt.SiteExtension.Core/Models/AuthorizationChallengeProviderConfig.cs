﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsEncrypt.Azure.Core.Models
{
    public class AuthorizationChallengeProviderConfig : IAuthorizationChallengeProviderConfig
    {
        public bool DisableWebConfigUpdate
        {
            get; set;
        }
    }
}

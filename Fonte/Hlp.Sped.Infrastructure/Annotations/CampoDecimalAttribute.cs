﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Annotations.Base;

namespace Hlp.Sped.Infrastructure.Annotations
{
    public class CampoDecimalAttribute : TipoCampoAttribute
    {
        public int CasasDecimais { get; set; }
    }
}

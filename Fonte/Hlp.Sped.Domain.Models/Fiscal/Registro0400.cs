﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro0400 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0400"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 10)]
        public string COD_NAT { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 150)]
        public string DESCR_NAT { get; set; }
    }
}

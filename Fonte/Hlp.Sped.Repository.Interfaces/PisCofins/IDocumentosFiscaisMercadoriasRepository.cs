﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Repository.Interfaces.PisCofins
{
    public interface IDocumentosFiscaisMercadoriasRepository
    {
        IEnumerable<RegistroC010> GetRegistrosC010();
    }
}
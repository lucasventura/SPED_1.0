﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Repository.Interfaces.Contmatic
{
    public interface IEmpresasRepository
    {
        IEnumerable<Empresa> ListAll();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro0100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0100"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 100)]
        public string NOME { get; set; }

        [CampoTextoNumerico(Ordem = 3, ComprimentoFixo = true, Tamanho = 11)]
        public string CPF { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 15)]
        public string CRC { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoNumerico(Ordem = 6, ComprimentoFixo = true, Tamanho = 8)]
        public string CEP { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 60)]
        public string END { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 10)]
        public string NUM { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 60)]
        public string COMPL { get; set; }

        [CampoTextoVariavel(Ordem = 10, Tamanho = 60)]
        public string BAIRRO { get; set; }

        [CampoTextoVariavel(Ordem = 11, Tamanho = 10)]
        public string FONE { get; set; }

        [CampoTextoVariavel(Ordem = 12, Tamanho = 10)]
        public string FAX { get; set; }

        [CampoTextoVariavel(Ordem = 13)]
        public string EMAIL { get; set; }

        [CampoTextoNumerico(Ordem = 14, ComprimentoFixo = true, Tamanho = 5)]
        public string COD_MUN { get; set; }
    }
}

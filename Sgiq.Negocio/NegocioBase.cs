﻿using Sgiq.Dados;
using System;

namespace Sgiq.Negocio
{
    public abstract class NegocioBase
    {
        public NegocioBase()
        {
            Db = new SGIQContext();
        }

        protected SGIQContext Db { get; set; }
    }
}

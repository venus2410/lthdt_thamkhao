﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface ILuuTruTamGiac
    {
        TamGiac DocTamGiac();
        void LuuTamGiac(TamGiac tamGiac);
    }
}

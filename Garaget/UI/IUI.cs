﻿using Garaget.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaget.UI
{
    public interface IUI
    {
        string GetInput();
        void Print(string message);

        void Clear();

        void Input(string message);

    } 
}


﻿using OutSystems.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAPITest
{
    interface ElementToggle
    {
        void getDifElements(IESpace old, IESpace newe, String newOrAltered);

        void insertIf(IESpace espace, List<IKey> keys);
    }
}
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Adapter;
using BH.oM.Base;

namespace BH.UI.Civil.Adapter
{
    public partial class CivilUIAdapter : BHoMAdapter
    {

        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        public CivilUIAdapter()
        {
            AdapterIdName = "Civil3D_Adapter";
            m_AdapterSettings.DefaultPushType = oM.Adapter.PushType.CreateOnly;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    /*interface IOrderRepair
    {
        void ProcessOrder(string modelName);
        void ProcessPhoneRepair(string modelName);
        void ProcessAccessoryRepair(string accessoryType);
    }*/
    interface IOrder
    {
        void ProcessOrder(string modelName);
    }
    interface IPhoneRepair
    {
        void ProcessPhoneRepair(string modelName);
        
    }
    interface IAccessoryRepair
    {
        void ProcessAccessoryRepair(string accessoryType);
    }
}
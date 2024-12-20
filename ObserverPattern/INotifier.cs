﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal interface INotifier
    {
        string Id { get; set; }
        public void Notify(object data);
    }
}

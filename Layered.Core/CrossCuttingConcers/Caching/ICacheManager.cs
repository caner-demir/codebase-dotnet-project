﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Core.CrossCuttingConcers.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        Object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key);
        void Remove(string key);
    }
}

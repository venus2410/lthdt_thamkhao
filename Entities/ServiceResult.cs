﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public ServiceResult(bool issc,T data, string msg)
        {
            IsSuccess = issc;
            Data = data;
            Message = msg;
        }
    }
}

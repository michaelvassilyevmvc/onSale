﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Common.Enums
{
    public enum OrderStatus
    {
        Pending, //В ожидании
        Spreading, //Распространение
        Sent, //Отправлено
        Confirmed //Подтверждено
    }
}

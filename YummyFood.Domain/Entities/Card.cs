﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YummyFood.Domain.Entities.Auth;

namespace YummyFood.Domain.Entities
{
    public class Card
    {
        public long UserId { get; set; }
        public UserApp User { get; set; }
    }
}
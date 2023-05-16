﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo8tareb_RoomRentalWebApp.BL.Dtos.Accounts
{

    public class TokenRequestModel
    {
        public required string Email { get; set; }

        public required string Password { get; set; }
    }
}

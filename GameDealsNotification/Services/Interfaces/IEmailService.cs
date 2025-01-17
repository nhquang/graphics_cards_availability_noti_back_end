﻿using GameDealsNotification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameDealsNotification.Services.Interfaces
{
    public interface IEmailService
    {
        Task<bool> SendNotiAsync(Notification notification, SpecificGame deal);
        Task<bool> SendConfirmationEmailAsync(Notification notification);
    }
}

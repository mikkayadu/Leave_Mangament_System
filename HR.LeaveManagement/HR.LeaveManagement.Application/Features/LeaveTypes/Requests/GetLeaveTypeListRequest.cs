﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Application.DTOs

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests
{
    public class GetLeaveTypeListRequest:IRequest<List<LeaveTypeDto>>
    {

    }
}

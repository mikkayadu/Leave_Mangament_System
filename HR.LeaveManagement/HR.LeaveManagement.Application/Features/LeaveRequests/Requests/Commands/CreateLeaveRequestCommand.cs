﻿using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.Reponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }

    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeRequestHandler:IRequestHandler<CreateLeaveTypeRequest, int>
    {
        public Task<int> Handle (CreateLeaveTypeRequest request, CancellationToken cancellationToken)
        {
            
        }

    }
    
}

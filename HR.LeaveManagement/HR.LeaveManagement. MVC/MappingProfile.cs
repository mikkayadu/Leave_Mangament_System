using AutoMapper;
using HR.LeaveManagement.Domain;
using HR.LeaveManagement.MVC.Models;
using HR.LeaveManagement.Application.DTOs.LeaveType;
namespace HR.LeaveManagement.MVC
{ 
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<HR.LeaveManagement.MVC.Services.Base.CreateLeaveTypeDto, CreateLeaveTypeVM>().ReverseMap();
        
        CreateMap<HR.LeaveManagement.MVC.Services.Base.LeaveTypeDto, LeaveTypeVM>().ReverseMap();

       
    }



    }

   

    }
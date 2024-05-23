using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = CRUD.Models;
using BO = CRUD.Training.BusinessObject;

namespace CRUD.Training.Profiles
{
    public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.Course, BO.Course>().ReverseMap();

        }
    }
}

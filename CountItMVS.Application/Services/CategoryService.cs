using AutoMapper;
using CountItMVC.Application.Interfaces;
using CountItMVC.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountItMVC.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }
    }
}

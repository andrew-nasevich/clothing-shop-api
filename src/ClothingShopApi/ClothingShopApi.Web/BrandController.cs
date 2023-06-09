﻿using ClothingShopApi.Abstract.Interfaces;
using ClothingShopApi.Abstract.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShopApi.Web
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController: ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrandController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Brand>> GetBrands()
        {
            return _unitOfWork.BrandRepository.GetAll();
        }
    }
}

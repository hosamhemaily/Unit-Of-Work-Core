using System;
using System.Collections.Generic;
using System.Text;
using UOW.Repository;

namespace UOW.Sevice
{
    public class BaseService
    {
        public readonly IUnitOfWork _unitOfWork;
        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}

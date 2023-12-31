﻿using RealHomeProject.Business.Abstract;
using RealHomeProject.DataAccess.Abstract;
using RealHomeProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.Concrete
{
    public class TermAndConditionManager: ITermAndConditionService
    {
        private readonly ITermAndConditionDal _termAndConditionDal;

        public TermAndConditionManager(ITermAndConditionDal termAndConditionDal)
        {
            _termAndConditionDal = termAndConditionDal;
        }

        public void TAdd(TermAndCondition t)
        {
           _termAndConditionDal.Insert(t);
        }

        public void TDelete(TermAndCondition t)
        {
            _termAndConditionDal.Delete(t);
        }

        public List<TermAndCondition> TGetAll(Expression<Func<TermAndCondition, bool>>? filter)
        {
            if (filter == null)
            {
                return _termAndConditionDal.GetAll();
            }
            return _termAndConditionDal.GetAllByFilter(filter);
        }

        public TermAndCondition TGetByFilter(Expression<Func<TermAndCondition, bool>> filter = null)
        {
            return _termAndConditionDal.GetByFilter(filter);
        }
        public void TUpdate(TermAndCondition t)
        {
            _termAndConditionDal.Update(t);
        }
    }
}

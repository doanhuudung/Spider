﻿#region ----------------备注----------------
// Author:CK 
// FileName:CarSeriesDataAccess.cs 
// Create Date:2017-09-06
// Create Time:11:09 
#endregion

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SpiderIDataAccess.IDapperDataAccess;
using SpiderModel.Entity;
using SpiderModel.Models;

namespace SpiderDataAccess.DapperDataAccess
{
    public class CarSeriesDataAccess : DapperDataAccess<CarSeriesEntity>, ICarSeriesDataAccess
    {
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="car">实体对象</param>
        /// <returns></returns>
        public bool Delete(CarSeriesEntity car)
        {
           return base.Delete(car);
        } 
    }
}
﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FytSoa.Core.Model.Erp
{
    ///<summary>
    /// 采购单表
    ///</summary>
    public partial class ErpPurchase
    {
        public ErpPurchase()
        {


        }
        /// <summary>
        /// Desc:采购单唯一编号
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Guid { get; set; }

        /// <summary>
        /// 采购单编号
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Desc:供应商
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string SupplierGuid { get; set; }

        /// <summary>
        /// Desc:联系人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Contacts { get; set; }

        /// <summary>
        /// Desc:联系电话
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Mobile { get; set; }

        /// <summary>
        /// Desc:采购金额
        /// Default:0
        /// Nullable:False
        /// </summary>           
        public decimal Money { get; set; } = 0;

        /// <summary>
        /// Desc:交付区域
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DeliverCity { get; set; }

        /// <summary>
        /// Desc:交付日期
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime DeliverDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Desc:操作人
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string AdminGuid { get; set; }

        /// <summary>
        /// Desc:属性=自定义 Json对象
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Attribute { get; set; }

        /// <summary>
        /// Desc:状态 1=未完成入库  2=未完成付款  3=未完成到票  4=完成
        /// Default:1
        /// Nullable:False
        /// </summary>           
        public int Status { get; set; } = 1;

        /// <summary>
        /// Desc:状态 是否删除 0=否  1=是
        /// Default:1
        /// Nullable:False
        /// </summary>           
        public bool IsDel { get; set; } = false;

        /// <summary>
        /// Desc:备注
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Summary { get; set; }

        /// <summary>
        /// Desc:采购日期
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime AddDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Desc:采购单商品列表
        /// Default:
        /// Nullable:True
        /// </summary>      
        [SugarColumn(IsIgnore = true)]
        public string  GoodsList{ get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFramework.Common.Message.Base
{
    public class Page
    {
        private int pageSize = 50;
        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private int pageIdx = 1;
        /// <summary>
        /// 页号
        /// </summary>
        public int PageIdx
        {
            get { return pageIdx; }
            set { pageIdx = value; }
        }

        private int recordsCount;

        /// <summary>
        /// 记录数
        /// </summary>
        public int RecordsCount
        {
            get { return recordsCount; }
            set { recordsCount = value; }
        }

        /// <summary>
        /// 页数
        /// </summary>
        public int PageCount
        {
            get
            {
                if (RecordsCount < 1) return 0;
                return RecordsCount % PageSize == 0 ?
                    RecordsCount / PageSize : RecordsCount / PageSize + 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Afx.Common.Message.Base
{
    public abstract class Message
    {
        /// <summary>
        /// 序列号
        /// </summary>
        public string SerialNo { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

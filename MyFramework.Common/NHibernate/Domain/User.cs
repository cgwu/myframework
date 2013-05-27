using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFramework.Common.NHibernate.Domain
{
    public class User
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Password{ get; set; }
        public virtual DateTime Birthday { get; set; }
    }
}

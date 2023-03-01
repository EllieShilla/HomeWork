using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class EnumMemberAttr
    {
        public string GetEnumMemberAttrValue<T>(T enumVal)
        {
            var enumType = typeof(T);
            var memInfo = enumType.GetMember(enumVal.ToString());
            var attr = memInfo.FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();
            if (attr != null)
            {
                return attr.Value;
            }

            return null;
        }
    }
}

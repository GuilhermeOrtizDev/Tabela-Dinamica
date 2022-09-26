using System.ComponentModel;
using System.Reflection;

namespace Web
{
    public static class Utils
    {
        public static String? GetDisplayName(Type? type, PropertyInfo info, bool hasMetaDataAttribute)
        {
            if (!hasMetaDataAttribute)
            {
                object[] attributes = info.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    var displayName = (DisplayNameAttribute)attributes[0];
                    return displayName.DisplayName;
                }
                return info.Name;
            }

            PropertyDescriptor? propDesc = TypeDescriptor.GetProperties(type).Find(info.Name, true);
            DisplayNameAttribute? displayAttribute = propDesc?.Attributes.OfType<DisplayNameAttribute>().FirstOrDefault();
            return displayAttribute?.DisplayName;
        }
    }
}

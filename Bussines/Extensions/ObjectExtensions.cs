using System;

namespace Business.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNotNull(this Object @object)
        {
            return !IsNull(@object);
        }

        public static bool IsNull(this Object @object)
        {
            return @object == null;
        }
    }
}
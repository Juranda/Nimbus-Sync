using System.Reflection;

namespace NimbusSync.Server.Domain
{
    public static class ModelUtils
    {
        public static bool AllPropetiesAreNull<T>(this T obj)
        {
            return obj == null || obj.GetType().GetProperties().All(p => p.GetValue(obj) == null);
        }

        public static List<PropertyInfo> GetNotNullProperties(this object obj)
        {
            var props = obj.GetType().GetProperties().ToList();

            props = props.Where(p =>
            {
                var value = p.GetValue(obj);

                if (value == null) return false;

                if (p.PropertyType == typeof(string) && string.IsNullOrEmpty((string)value)) return false;

                if (Array.Empty<byte>() == value) return false;

                return true;
            }).ToList();

            return props;
        }

        public static bool CheckIfContains(this string stringA, string stringB)
        {

            return string.IsNullOrEmpty(stringA) || stringB.ToLower().Contains(stringA);
        }
    }
}

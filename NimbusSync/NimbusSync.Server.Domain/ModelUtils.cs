namespace NimbusSync.Server.Domain
{
    public static class ModelUtils
    {
        public static bool AllPropetiesAreNull<T>(this T obj)
        {
            return obj == null || obj.GetType().GetProperties().All(p => p.GetValue(obj) == null);
        }
    }
}

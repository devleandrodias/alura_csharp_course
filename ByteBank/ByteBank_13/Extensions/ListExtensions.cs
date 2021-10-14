using System.Collections.Generic;

namespace ByteBank_13.Extensions
{
    internal static class ListExtensions
    {
        public static void PersonalList<T>(this List<T> list, params T[] itens)
        {
            foreach (T item in itens)
            {
                list.Add(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace SyncAPI
{
    public static class HelpFuncs
    {
        public static IEnumerable<List<T>> DividirLista<T>(List<T> lista, int tamañoSubListas)
        {
            for (int i = 0; i < lista.Count; i += tamañoSubListas)
                yield return lista.GetRange(i, Math.Min(tamañoSubListas, lista.Count - i));
        }
    }
}

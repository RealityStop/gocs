﻿using System;
using System.Collections.Generic;

namespace Lazlo.Gocs
{
	internal static class DictionaryPool<TKey, TValue>
	{
		private static readonly Stack<Dictionary<TKey, TValue>> free = new Stack<Dictionary<TKey, TValue>>();

		private static readonly HashSet<Dictionary<TKey, TValue>> busy = new HashSet<Dictionary<TKey, TValue>>(ReferenceEqualityComparer<Dictionary<TKey, TValue>>.Instance);

		// Do not allow an IDictionary parameter here to avoid allocation on foreach
		public static Dictionary<TKey, TValue> New(Dictionary<TKey, TValue> source = null)
		{
			if (free.Count == 0)
			{
				free.Push(new Dictionary<TKey, TValue>());
			}

			var dictionary = free.Pop();

			busy.Add(dictionary);

			if (source != null)
			{
				foreach (var kvp in source)
				{
					dictionary.Add(kvp.Key, kvp.Value);
				}
			}

			return dictionary;
		}

		public static void Free(Dictionary<TKey, TValue> dictionary)
		{
			if (!busy.Contains(dictionary))
			{
				throw new ArgumentException("The dictionary to free is not in use by the pool.", nameof(dictionary));
			}

			dictionary.Clear();

			busy.Remove(dictionary);

			free.Push(dictionary);
		}
	}

	public static class XDictionaryPool
	{
		public static void Free<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
		{
			DictionaryPool<TKey, TValue>.Free(dictionary);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmojiSearch.Code
{
    public static class StringExtensions
    {
        public static bool ContainsAny(this string target, params string[] values)
        {
            if (!string.IsNullOrEmpty(target) || values.Length > 0)
            {
                foreach (string value in values)
                {
                    if (target.Contains(value))
                        return true;
                }
            }

            return false;
        }

        public static bool ContainsAny(this string[] target, params string[] values)
        {
            if (target != null || !values.Any())
            {
                foreach (string value in values)
                {
                    if (target.Contains(value))
                        return true;
                }
            }

            return false;
        }

        public static bool LikeAny(this string[] target, params string[] values)
        {
            if (target != null || !values.Any())
            {
                foreach (string value in values)
                {
                    foreach (var t in target)
                    {
                        int index = t.IndexOf(value);
                        if (index > -1)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}

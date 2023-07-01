using UnityEngine;

namespace Algorithms.Search {
    public class PatternSearch {
        public static void search(char[] pat, char[] txt) {
            int M = pat.Length;
            int N = txt.Length;

            /* A loop to slide pat[] one by one */
            for (int i = 0; i <= N - M; i++) {
                int j;

                /* For current index i, check for pattern match
                       */
                for (j = 0; j < M; j++)
                    if (txt[i + j] != pat[j])
                        break;

                if (j == M) // if pat[0...M-1] = txt[i, i+1,
                            // ...i+M-1]
                    Debug.Log("Pattern found at index "
                                      + i);
            }
        }
    }
}

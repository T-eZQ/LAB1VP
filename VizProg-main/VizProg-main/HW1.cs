using System;
using System.Collections.Generic;
using System.Text;

namespace HW
{
    class HW1
    {
        public static long QueueTime(int[] customers, int n) {
            int time = 0;
            int[] cassy = new int[n];
            for (int i = 0; i < n; i++) {
                cassy[i] = 0;
            }
            int quee_l = n > customers.Length ? 0 : customers.Length - n;
            int quee_n = n > customers.Length ? 0 : n;
            int count = 0;

            for (int i = 0; i < (n < customers.Length ? n : customers.Length); i++) {
                cassy[i] = customers[i];
            }

            while (true) {
                time++;
                count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (cassy[i] > 0)
                    {
                        cassy[i]--;
                        if (cassy[i] == 0)
                        {
                            if (quee_l == 0)
                            {
                                count++;
                            }
                            else
                            {
                                cassy[i] = customers[quee_n++];
                                quee_l--;
                            }
                        }
                    }
                    else
                    {
                        if (quee_l == 0)
                        {
                            count++;
                        }
                        else
                        {
                            cassy[i] = customers[quee_n++];
                            quee_l--;
                        }
                    }
                }
                if (count == n)
                    return time;
            }
        }
    }
}

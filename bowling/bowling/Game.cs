using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
    class Game
    {  
        int []score=new int [20];
        internal void SetPins(int p,int i)
        {
            score[i] = p;
        }
        internal int GetFinalScore()
        {
        
            int sum=0;
            for (int i = 0; i < 20; i+=2)
            {
                if (score[i] + score[i + 1] == 10)
                {  
                    sum+=10;
                    if (score[i] == 10)
                        sum += Strike(i);
                    else
                        sum += score[i + 2];
                }
                else sum += (score[i] + score[i + 1]);
            }
            return sum;
         } 
        int Strike(int i)
        {
            int ans=0;
            for (int j = 0; j < 2; )
            {
                i++;
                if(score[i]!=0)
                {
                    ans += score[i];
                    j++;
                }
            }
            return ans;
        }
    }
}

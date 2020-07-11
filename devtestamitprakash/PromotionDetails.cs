using System;
namespace devtestamitprakash
{
    public class PromotionDetails
    {
        
            // Promo for type A
            public int promoType1(int A)
            {

                if (A > 0 && A < 3)
                {
                    return A * 50;
                }
                else if (A >= 3)
                {
                    int org = (A % 3) * 50;
                    int promoPrice = (A / 3) * 130;
                    return org + promoPrice;
                }
                return 0;

            }

        // Promo for type B
        public int promoType2(int B)
        {
            if (B >= 2)
            {
                int org = (B % 2) * 30;
                int promoPrice = (B / 2) * 45;
                return org + promoPrice;
            }
            else if (B == 1)
            {
                return 30;
            }

            return 0;
        }

        //promo form type C & D
        public int promoType3(int C, int D)
        {
            if (C == 1 && D == 1)
            {
                return 30;
            }

            else if (C == 1 & D == 0)
            {
                return C * 20;
            }

            else if (C == 0 & D == 1)
            {
                return D * 15;
            }

            else if (C >= 1 || D >= 1)
            {
                if (C > D)
                {
                    return (C - D) * 20 + D * 30;
                }
                else
                    return (D - C) * 15 + C * 30;
            }

            return 0;
        }


    }
}

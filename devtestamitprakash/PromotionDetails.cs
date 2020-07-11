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
        
    }
}

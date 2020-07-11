using System;
namespace devtestamitprakash
{
    public class UserInput :IPriceCalculation
    {
        public void orderDetails()
        {

            string[] orders = new string[4];
            Console.WriteLine("----------------Please proveide your order details for respetive SKU(s)---------------------");
            Console.WriteLine("Order count for SKU: A");
            var val0 = Console.ReadLine();
            Console.WriteLine("Order count for SKU: B");
            var val1 = Console.ReadLine();

            Console.WriteLine("Order count for SKU: C");
            var val2 = Console.ReadLine();

            Console.WriteLine("Order count for SKU: D");
            var val3 = Console.ReadLine();
            orders[0] = val0;
            orders[1] = val1;
            orders[2] = val2;
            orders[3] = val3;

            orderNumberValidation(orders);
        }
        public void orderNumberValidation(string[] orders)
        {

            int aSKU = 0, bSKU = 0, cSKU = 0, dSKU = 0;
            int[] orderFinalQuantity = new int[4];
            if (int.TryParse(orders[0], out aSKU) && int.TryParse(orders[1], out bSKU) && int.TryParse(orders[2], out cSKU) && int.TryParse(orders[3], out dSKU))
            {
                orderFinalQuantity[0] = aSKU;
                orderFinalQuantity[1] = bSKU;
                orderFinalQuantity[2] = cSKU;
                orderFinalQuantity[3] = dSKU;

                orderSummary(orderFinalQuantity);
                finalPriceCalculation(orderFinalQuantity);

            }
            else
            {
                Console.WriteLine("Some worng data format has been detected in orders quantity.. \n please try again");
                orderDetails();
            }
        }
        public void orderSummary(int[] ordersummary)
        {
            Console.WriteLine("===================Order Details=======================");
            Console.WriteLine(" SKU(s)\tquantity\tActualPrice/Unit");
            Console.Write("A");
            Console.Write("\t" + ordersummary[0]);
            Console.Write("\t\t50");
            Console.Write("\nB");
            Console.Write("\t" + ordersummary[1]);
            Console.Write("\t\t30");
            Console.Write("\nC");
            Console.Write("\t" + ordersummary[2]);
            Console.Write("\t\t20");
            Console.Write("\nD");
            Console.Write("\t" + ordersummary[3]);
            Console.Write("\t\t15");


        }
        /// <summary>
        /// Final price calacuation after appplying Promo
        /// </summary>
        /// <param name="orderCount"></param>
        public void finalPriceCalculation(int[] orderCount)
        {
            PromotionDetails _promotionDetails = new PromotionDetails();
            int actualCost = orderCount[0] * 50 + orderCount[1] * 30 + orderCount[2] * 20 + orderCount[3] * 15;
            int finalPrice = _promotionDetails.promoType1(orderCount[0]) +
             _promotionDetails.promoType2(orderCount[1]) +
             _promotionDetails.promoType3(orderCount[2], orderCount[3]);

            Console.WriteLine("\nActual Cost= " + actualCost.ToString());
            Console.WriteLine("Promotional Discunt= " + (actualCost - finalPrice).ToString());
            Console.WriteLine("Total Payable Amount= " + finalPrice.ToString());
            Console.WriteLine("================================================");
            //Console.WriteLine(finalPrice.ToString());
        }


    }
}

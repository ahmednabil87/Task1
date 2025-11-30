string intro = "   Islam's Carpet Cleaning Service" + "\n"
             + "      Charges:" + "\n"
             + "      $25 per small" + "\n"
             + "      $35 per large" + "\n"
             + "      sales tax rate is 6%" + "\n"
             + "   Estimates are valid for 30 days";
Console.WriteLine(intro);
Console.WriteLine("Estimates for carpet cleaning service");
Console.Write("Number of small carpets:");
int small = Convert.ToInt32(Console.ReadLine());
Console.Write("Number of large carpets:");
int large = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("price per small carpet: $25");
Console.WriteLine("price per large carpet: $35");
Console.Write("Cost : ");
Console.WriteLine($"{small * 25 + large * 35:C}");
Console.Write("Tax: ");
Console.WriteLine($"{(small * 25 + large * 35) * .06:C}");
Console.WriteLine("=====================================");
Console.Write("Total estimate: ");
Console.WriteLine($"{small * 25 + large * 35 + (small * 25 + large * 35) * .06:C}");
Console.WriteLine("This estimate is valid for 30 days");
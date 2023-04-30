﻿
Console.WriteLine("***************************************************");
Console.WriteLine("*                   Supermarket                   *");
Console.WriteLine("***************************************************");

Product[] products = new Product[]
{
    new FixedPriceProduct
    {
        Id = 1,
        Name = "Coca Cola",
        DiscountPercentaje = 0.1f,
        TaxPercentaje = 0.05f,
        Price = 2500
    },
    new FixedPriceProduct
    {
        Id = 2,
        Name = "Leche",
        DiscountPercentaje = 0.2f,
        TaxPercentaje = 0,
        Price = 5000
    },
    new FixedPriceProduct
    {
        Id = 3,
        Name = "Pan",
        DiscountPercentaje = 0,
        TaxPercentaje = 0.12f,
        Price = 3000
    },
    new VariablePriceProduct
    {
        Id = 4,
        Name = "Carne",
        UnitOfMeasure = "Kilo",
        PricePerUnitOfMeasure = 22000,
        Quantity = 2.5f,
        DiscountPercentaje = 0.3f,
        TaxPercentaje = 0.12f
    },
    new VariablePriceProduct
    {
        Id = 5,
        Name = "Alambre",
        UnitOfMeasure = "Metros",
        PricePerUnitOfMeasure = 5600,
        Quantity = 30.8f,
        DiscountPercentaje = 0.25f,
        TaxPercentaje = 0.07f
    },
};

decimal totalDiscount = 0;
decimal totalTax = 0;
decimal totalValue = 0;
foreach (var product in products)
{
    Console.WriteLine(product);
    totalDiscount += product.CalculateDiscount();
    totalTax += product.CalculateTax();
    totalValue += product.CalculateValueToPay();
}

Console.WriteLine($"                                ===================");
Console.WriteLine($"Total Discount                 {totalDiscount,20:C2}");
Console.WriteLine($"Total Tax                      {totalTax,20:C2}");
Console.WriteLine($"Total Value                    {totalValue,20:C2}");




Debe generar exactamente esta salida:

***************************************************
*Supermarket *
***************************************************
1       Coca Cola
        % Discount...........:               10.00 %
        % Tax................:                5.00 %
        Price................:            $2,500.00
        Discount value.......:              $250.00
        Tax value............:              $125.00
        Value to pay.........:            $2,375.00
2       Leche
        % Discount...........:               20.00%
        % Tax................:                0.00%
        Price................:            $5,000.00
        Discount value.......:            $1,000.00
        Tax value............:                $0.00
        Value to pay.........:            $4,000.00
3       Pan
        % Discount...........:                0.00%
        % Tax................:               12.00%
        Price................:            $3,000.00
        Discount value.......:                $0.00
        Tax value............:              $360.00
        Value to pay.........:            $3,360.00
4       Carne
        % Discount...........:               30.00%
        % Tax................:               12.00%
        Unit of eeasure......: Kilo
        Quantity.............:                 2.50
        Price................:           $22,000.00
        Discount value.......:           $16,500.00
        Tax value............:            $6,600.00
        Value to pay.........:           $45,100.00
5       Alambre
        % Discount...........:               25.00%
        % Tax................:                7.00%
        Unit of eeasure......: Metros
        Quantity.............:                30.80
        Price................:            $5,600.00
        Discount value.......:           $43,120.00
        Tax value............:           $12,073.60
        Value to pay.........:          $141,433.60
                                ===================
Total Discount                           $60,870.00
Total Tax                                $19,158.60
Total Value                             $196,268.60





namespace POO.logic
{
    public class FixedPriceProduct 
    { 
        private double _price;

        public FixedPriceProduct()
        {
            _price = price;
        }

        public double price 
        { 
            get => _price;
            set => _price = value;
        }
        
        public override string ToString()
        {
            return price.ToString();
        }

        public  double calculateDiscount(double price) 
        {
            
        }
        public double calculateTax(double price) 
        {
            
        }

        public double calculateValueToPay(double price)
        {

        }

        private double validateGreatherThanZero(double price)
        {

        }
    }
}
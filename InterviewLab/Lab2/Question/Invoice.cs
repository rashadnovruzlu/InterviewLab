namespace InterviewLab.Lab2.Question
{
    public class Invoice
    {
        public readonly Book Book;
        public readonly int Quantity;
        public readonly double DiscountRate;
        public readonly double TaxRate;
        public readonly double Total;


        public Invoice(Book book, int quantity, double discountRate, double taxRate)
        {
            this.Book = book;
            this.Quantity = quantity;
            this.DiscountRate = discountRate;
            this.TaxRate = taxRate;
            this.Total = this.CalculateTotal();
        }

        double CalculateTotal()
        {
            double price = ((Book.Price - Book.Price * DiscountRate) * Quantity);

            double priceWithTaxes = price * (1 + TaxRate);

            return priceWithTaxes;
        }

        public void PrintInvoice()
        {
            Console.WriteLine(Quantity + "x " + Book.Name + " " + Book.Price + "$");
            Console.WriteLine("Discount Rate: " + DiscountRate);
            Console.WriteLine("Tax Rate: " + TaxRate);
            Console.WriteLine("Total: " + Total);
        }

        public void SaveToFile(string filename)
        {
            // Creates a file with given name and writes the invoice
        }
    }
}

using InterviewLab.Lab1.Question;

namespace InterviewLab.Lab1.Answer
{
    public class InvoicePrinter
    {
        private Invoice invoice;

        public InvoicePrinter(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void Print()
        {
            Console.WriteLine(invoice.Quantity + "x " + invoice.Book.Name + " " + invoice.Book.Price + " $");
            Console.WriteLine("Discount Rate: " + invoice.DiscountRate);
            Console.WriteLine("Tax Rate: " + invoice.TaxRate);
            Console.WriteLine("Total: " + invoice.Total + " $");
        }
    }
}

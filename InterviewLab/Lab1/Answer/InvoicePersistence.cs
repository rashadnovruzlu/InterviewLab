using InterviewLab.Lab1.Answer;
using InterviewLab.Lab1.Question;

namespace InterviewLab.Lab1.Answer
{
    public class InvoicePersistence
    {
        Invoice invoice;

        public InvoicePersistence(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void saveToFile(string filename)
        {
            // Creates a file with given name and writes the invoice
        }
    }
}

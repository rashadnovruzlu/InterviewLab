using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewLab.Lab2.Question
{
    public class InvoicePersistence
    {
        Invoice invoice;

        public InvoicePersistence(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void saveToFile(String filename)
        {
            // Creates a file with given name and writes the invoice
        }

        public void saveToDatabase()
        {
            // Saves the invoice to database
        }
    }
}

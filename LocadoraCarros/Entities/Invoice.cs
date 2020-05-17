using System.Globalization;
using System.Text;

namespace LocadoraCarros.Entities
{
    class Invoice
    {
        public double BasicPaymente { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPaymente, double tax)
        {
            BasicPaymente = basicPaymente;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPaymente + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Valor: {BasicPaymente.ToString("F2", CultureInfo.InvariantCulture)}\n");
            sb.Append($"Taxa: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n");
            sb.Append($"Total: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}

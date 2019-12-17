using System;
using System.Globalization;

namespace CourseProductImportedUsed.Entities {
    public class UsedProduct : Product {
        public DateTime MannufactureDate { get; set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime mannufactureDate)
            : base(name, price) {
            MannufactureDate = mannufactureDate;
        }

        public override string PriceTag() {
            return Name + " (used) , $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Mannufacture date: " + MannufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}

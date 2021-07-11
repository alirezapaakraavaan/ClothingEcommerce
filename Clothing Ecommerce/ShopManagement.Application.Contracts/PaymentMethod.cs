using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Application.Contracts
{
    public class PaymentMethod
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        private PaymentMethod(int id, string description, string name)
        {
            Id = id;
            Description = description;
            Name = name;
        }

        public static List<PaymentMethod> GetList()
        {
            return new List<PaymentMethod>
            {
                new PaymentMethod(1, "پرداخت اینترنتی و تحویل درب منزل", "پرداخت اینترنتی"),
                new PaymentMethod(2, "پرداخت نقدی و تحویل درب منزل", "پرداخت نقدی")
            };
        }

        public static PaymentMethod GetBy(long id)
        {
            return GetList().FirstOrDefault(x => x.Id == id);
        }
    }
}
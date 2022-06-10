using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Enum_____ExercicioFixação3.Entities.StatusOrder;


namespace Enum_____ExercicioFixação3.Entities
{
    class Order
    {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrdemItem> Item { get; set; } = new List<OrdemItem>();
        
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrdemItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach(OrdemItem item in Item)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder Text = new StringBuilder();
            Text.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            Text.AppendLine("Order Status: " + Status);
            Text.AppendLine("Client: " + Client);
            Text.AppendLine("Oredr items: ");
            foreach(OrdemItem item in Item)
            {
                Text.AppendLine(item.ToString());
            }
            Text.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return Text.ToString();
        }
    }
}

using System;
using ExPropostoSecao7.Entities.Enum;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExPropostoSecao7.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Item { get; set; } = new List<OrderItem>(); // Instanciamos a lista para que ela não seja nula

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach(OrderItem os in Item)
            {
                total += os.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem oi in Item)
            {
                sb.AppendLine(oi.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
            /*StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.Name + " (" + Client.BirthDate + ") " + " - " + Client.Email);
            sb.AppendLine("Order Itens:");
            foreach(OrderItem oi in Item)
            {
                sb.AppendLine(oi.ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();*/
        }
    }
}

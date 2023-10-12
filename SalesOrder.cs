using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BaiTELtask
{
    public class SalesOrder
    {
        [JsonPropertyName("order")]
        public SalesOrderData Order { get; set; }

        public void ToXmlFile(StreamWriter writer)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SalesOrder));
            serializer.Serialize(writer, this);
        }
    }

    public class SalesOrderData
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("total_grams")]
        public int TotalGrams { get; set; }
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }
        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
    }
}

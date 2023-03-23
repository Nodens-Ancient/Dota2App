using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Dota2App.DAL.Item
{
    public class ItemAttributeValue
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Value { get; set; }
    }
}

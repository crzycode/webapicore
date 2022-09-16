using System.ComponentModel.DataAnnotations;

namespace webapicore.Model
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
    }
}

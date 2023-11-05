using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Estado
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string estadoOption { get; set; } = string.Empty;
    }
}

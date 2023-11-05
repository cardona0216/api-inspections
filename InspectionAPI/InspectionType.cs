using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class InspectionType
    {
        public int Id {  get; set; }

        [StringLength(100)]
        public string InspectionName { get; set; } = string.Empty;
    }
}

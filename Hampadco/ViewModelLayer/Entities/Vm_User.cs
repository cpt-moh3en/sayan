using System.ComponentModel.DataAnnotations;

namespace ViewModelLayer.Entities
{
    public class Vm_User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Amount { get; set; }
    }
}
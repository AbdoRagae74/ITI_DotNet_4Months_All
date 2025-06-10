using System.ComponentModel.DataAnnotations;

namespace ITIMVC.ViewModels
{
    public class RegisterViewModel
    {

        public string Email { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string password{ get; set; }
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirmPassword{ get; set; }
        public string Address{ get; set; }
    }
}

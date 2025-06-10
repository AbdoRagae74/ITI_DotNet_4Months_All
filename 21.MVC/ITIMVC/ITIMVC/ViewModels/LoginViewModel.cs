using System.ComponentModel.DataAnnotations;

namespace ITIMVC.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string? DisplayName { get; set; }
        //public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string password{ get; set; }
        public bool rememberMe{ get; set; }
    }
}

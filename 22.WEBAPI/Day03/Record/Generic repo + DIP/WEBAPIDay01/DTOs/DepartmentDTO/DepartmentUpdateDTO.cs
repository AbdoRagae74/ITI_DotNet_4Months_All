namespace WEBAPIDay01.DTOs.DepartmentDTO
{
    public class DepartmentUpdateDTO
    {
        public int DeptId { get; set; }

        public string? DeptName { get; set; }

        public string? DeptDesc { get; set; }

        public string? DeptLocation { get; set; }

        public int? DeptManager { get; set; }
    }
}

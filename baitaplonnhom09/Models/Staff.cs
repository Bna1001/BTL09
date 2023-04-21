using System.ComponentModel.DataAnnotations;
namespace baitaplonnhom09.Models
{
    public class Staff
    {
        [Key]
        public string StaffID{ get; set; }
        [Display(Name = "Họ và tên")]
        public string StaffName{ get; set; }
        [Display(Name = "Vị trí")]
        public string StaffPosition{ get; set; }
         [Display(Name = "Lương")]
        public string StaffEarn{ get; set; }
         [Display(Name = "SĐT")]
        public string StaffPhoneNumber{ get; set; }
         [Display(Name = "Địa chỉ")]
        public string StaffAddress{ get; set; }
         [Display(Name = "Ngày Sinh")]
        public string StaffBirth{ get; set; }
        [Display(Name = "Giới tính")]
        public string StaffSex{ get; set; }
        [Display(Name = "TK Ngân hàng BIDV")]
        public string StaffBank{ get; set; }
         [Display(Name = "Ngày làm")]
        public string StaffStart{ get; set; }
        [Display(Name = "Hợp đồng")]
        public string StaffEnd{ get; set; }
    }
}
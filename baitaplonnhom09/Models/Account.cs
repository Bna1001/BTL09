using System.ComponentModel.DataAnnotations;
namespace baitaplonnhom09.Models
{
    public class Account
    {
        [Key]
        public string AccountID{ get; set; }
        [Display(Name = "Họ và tên")]
        public string AccountName{ get; set; }
        [Display(Name = "Vị trí")]
        public string AccountPosition{ get; set; }
        [Display(Name = "Lương")]
        public string AccountEarn{ get; set; }
        [Display(Name = "SĐT")]
        public string AccountPhoneNumber{ get; set; }
        [Display(Name = "Địa chỉ")]
        public string AccountAddress{ get; set; }
        [Display(Name = "Ngày Sinh")]
        public string AccountBirth{ get; set; }
        [Display(Name = "Giới tính")]
        public string AccountSex{ get; set; }
        [Display(Name = "TK Ngân hàng BIDV")]
        public string AccountBank{ get; set; }
         [Display(Name = "Ngày làm")]
        public string AccountStart{ get; set; }
        [Display(Name = "Hợp đồng")]
        public string AccountEnd{ get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
namespace baitaplonnhom09.Models
{
    public class Sale
    {
        [Key]
        public string SaleID{ get; set; }
        [Display(Name = "Họ và tên")]
        public string SaleName{ get; set; }
        [Display(Name = "Vị trí")]
        public string SalePosition{ get; set; }
         [Display(Name = "Lương")]
        public string SaleEarn{ get; set; }
         [Display(Name = "SĐT")]
        public string SalePhoneNumber{ get; set; }
         [Display(Name = "Địa chỉ")]
        public string SaleAddress{ get; set; }
         [Display(Name = "Ngày Sinh")]
        public string SaleBirth{ get; set; }
        [Display(Name = "Giới tính")]
        public string SaleSex{ get; set; }
        [Display(Name = "TK Ngân hàng BIDV")]
        public string SaleBank{ get; set; }
         [Display(Name = "Ngày làm")]
        public string SaleStart{ get; set; }
        [Display(Name = "Hợp đồng")]
        public string SaleEnd{ get; set; }
    }
}
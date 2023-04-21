using System.ComponentModel.DataAnnotations;
namespace baitaplonnhom09.Models
{
    public class Ceo
    {
        [Key]
        public string CeoID{ get; set; }
        [Display(Name = "Họ và tên")]
        public string CeoName{ get; set; }
        [Display(Name = "Vị trí")]
        public string CeoPosition{ get; set; }
        [Display(Name = "Lương")]
        public string CeoEarn{ get; set; }
        [Display(Name = "SĐT")]
        public string CeoPhoneNumber{ get; set; }
        [Display(Name = "Địa chỉ")]
        public string CeoAddress{ get; set; }
        [Display(Name = "Ngày Sinh")]
        public string CeoBirth{ get; set; }
        [Display(Name = "Giới tính")]
        public string CeoSex{ get; set; }
        [Display(Name = "TK Ngân hàng BIDV")]
        public string CeoBank{ get; set; }
        [Display(Name = "Ngày làm")]
        public string CeoStart{ get; set; }
        [Display(Name = "Hợp đồng")]
        public string CeoEnd{ get; set; }
    }
}
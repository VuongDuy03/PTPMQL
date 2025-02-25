using System.ComponentModel.DataAnnotations;

namespace BMICalculator.Models
{
    public class BMIModel
    {
        [Required(ErrorMessage = "Nhập cân nặng")]
        [Range(1, 300, ErrorMessage = "Cân nặng phải từ 1 - 300 kg")]
        public double Weight { get; set; } // Cân nặng (kg)

        [Required(ErrorMessage = "Nhập chiều cao")]
        [Range(0.5, 2.5, ErrorMessage = "Chiều cao phải từ 0.5 - 2.5 mét")]
        public double Height { get; set; } // Chiều cao (m)

        public double BMI { get; set; } // Chỉ số BMI
        public string Result { get; set; } // Kết quả đánh giá BMI
    }
}
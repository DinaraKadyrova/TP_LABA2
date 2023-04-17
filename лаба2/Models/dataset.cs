using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace лаба2.Models
{
    [DisplayName("новый пациент")]
    public class dataset
    {
        public string? id { get; set; }

        [DisplayName("Имя")]
        public string? name { get; set; }

        [DisplayName("Фамилия")]
        public string? lastname { get; set; }

        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? data { get; set; }

        [DisplayName("Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public uint number { get; set; }

        [DisplayName("Адрес")]
        public string? text { get; set; }

        [DisplayName("Пол")]
        public bool gender { get; set; }
    }

    public enum gender
    {
        female,
        male
        
    }
}

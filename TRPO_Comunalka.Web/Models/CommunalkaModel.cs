using System.ComponentModel;

namespace TRPO_Comunalka.Web.Models
{
    public class CommunalkaModel
    {
        [DisplayName("Количество прописанных человек)")]
        public int Human { get; set; }
        [DisplayName("Горячая вода(м3)")]
        public double H { get; set; }
        [DisplayName("Холодная вода(м3)")]
        public double C { get; set; }
        [DisplayName("Отопление(кВт*ч)")]
        public double F { get; set; }
        [DisplayName("Энергоснабжение(кВт*ч)")]
        public double En { get; set; }
        [DisplayName("Капитальный ремонт(м2)")]
        public double Kap { get; set; }
        [DisplayName("Содержание жилого помещения(м2)")]
        public double Space { get; set; }
        [DisplayName("Льгота")]
        public int L { get; set; }
    }
}
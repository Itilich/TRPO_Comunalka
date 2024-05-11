using System.ComponentModel;

namespace TRPO_Comunalka.Web.Models
{
    public class CommunalkaModel
    {
        [DisplayName("Горячая вода(м3)")]
        public double H { get; set; }
        [DisplayName("Холодная вода(м3)")]
        public double C { get; set; }
        [DisplayName("Вывоз ТБО(м3)")]
        public double F { get; set; }
        [DisplayName("Отопление(кВт*ч)")]
        public double T { get; set; }
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
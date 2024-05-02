namespace TRPO_Comunalka.Lib
{
    public class Comunalka
    {
        ///Расчет комунальных платежей
        ///Вода горячая - H, вода холодная - C, вывоз тбо - T, отопление - F, энергоснабжение - En, капитальный ремонт - Kap, содержание жилого помещение - Space, льгота - L.
        public static double Com(int L, double H, double C, double F, double T, double En, double Kap, double Space)
        {
            double k1 = 0.72; ///Инвалидность
            double k2 = 0.85; ///Работник образовательных учреждений
            double k3 = 0.7; ///Ветеран
            double k4 = 0.75; ///Пенсионер
            double k5 = 0.8; ///Многодетная семья
            double k6 = 1; ///Льгота отсутствует

            ///ошибки---------------------------------------------------------
            if (L <= 0)
            {
                throw new Exception("Льгота выбирается по списку от 1 до 6");
            }
            if (L > 6)
            {
                throw new Exception("Льгота выбирается по списку от 1 до 6");
            }
            if ((H < 0) || (C < 0) || (F < 0) || (T < 0) || (En < 0) || (Kap < 0) || (Space < 0))
            {
                throw new Exception("Комунальные данные не могут быть отрицательными!");
            }
            ///---------------------------------------------------------------

            switch (L)
            {
                case 1:
                    return ((H * 39) + (C * 15) + (T / 10 * 674) + (F * 100) + (En * 5) + (Kap * 15) + (Space * 10)) * k1;
                case 2:
                    return ((H * 39) + (C * 15) + (T / 10 * 674) + (F * 100) + (En * 5) + (Kap * 15) + (Space * 10)) * k2;
                case 3:
                    return ((H * 39) + (C * 15) + (T / 10 * 674) + (F * 100) + (En * 5) + (Kap * 15) + (Space * 10)) * k3;
                case 4:
                    return ((H * 39) + (C * 15) + (T / 10 * 674) + (F * 100) + (En * 5) + (Kap * 15) + (Space * 10)) * k4;
                case 5:
                    return ((H * 39) + (C * 15) + (T / 10 * 674) + (F * 100) + (En * 5) + (Kap * 15) + (Space * 10)) * k5;
                case 6:
                    return ((H * 39) + (C * 15) + (T / 10 * 674) + (F * 100) + (En * 5) + (Kap * 15) + (Space * 10)) * k6;
                default:
                    throw new InvalidOperationException("Недопустимое значение L.");
            }
        }
    }
}
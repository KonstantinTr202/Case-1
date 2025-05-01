using System;
using System.Drawing;

public class Result
{
    public static string _plan;//Стринговая пременная используемая для записи информации в текст бокс
    public static bool _proverka;// Булевая переменная используемая для проверки
    public static double _resultStal; // Руда
    public static double _resultNikel; // Никель
    public static double _resultChrome; // Хром
    public static double _resultMarganec; // Марганец
    public static double _resultPech; // Время доменной печи
    public static double _resultConvert; // Время конвертера
    public static double _resultProkat; // Время прокатного стана
    public static double _resultRub; // Общая прибыль
    public void result()
    {
        // Создаем объекты для доступных ресурсов и марок стали
        Reader marka = new Reader();
        DostupResur dostupResur = new DostupResur();
        Marka_A marka_A = new Marka_A();
        Marka_B marka_B = new Marka_B();
        Marka_C marka_C = new Marka_C();
        marka.Read();

        // Рассчитываем потребление ресурсов для производства
        _resultStal = marka_A._rudaStileA * Reader._markA + marka_B._rudaStileB * Reader._markB + marka_C._rudaStileC * Reader._markC; // Руда
        _resultNikel = marka_A._nikelA * Reader._markA + marka_B._nikelB * Reader._markB + marka_C._nikelC * Reader._markC; // Никель
        _resultChrome = marka_A._chromeA * Reader._markA + marka_B._chromeB * Reader._markB + marka_C._chromeC * Reader._markC; // Хром
        _resultMarganec = marka_A._marganecA * Reader._markA + marka_B._marganecB * Reader._markB + marka_C._marganecC * Reader._markC; // Марганец
        _resultPech = marka_A._pechA * Reader._markA + marka_B._pechB * Reader._markB + marka_C._pechC * Reader._markC; // Время доменной печи
        _resultConvert = marka_A._convertA * Reader._markA + marka_B._convertB * Reader._markB + marka_C._convertC * Reader._markC; // Время конвертера
        _resultProkat = marka_A._prokatA * Reader._markA + marka_B._prokatB * Reader._markB + marka_C._prokatC * Reader._markC; // Время прокатного стана
        _resultRub = marka_A._rubA * Reader._markA + marka_B._rubB * Reader._markB + marka_C._rubC * Reader._markC; // Общая прибыль

        Console.WriteLine ($"Марка стали A: {Reader._markA} тонн \r\nМарка стали B: {Reader._markB} тонн \r\nМарка стали C: {Reader._markC} тонн \r\n" +
            $"\nИспользованные ресурсы: \r\nРуда: {_resultStal} тонн \r\nНикель: {_resultNikel} кг \r\nХром: {_resultChrome} кг \r\nМарганец: {_resultMarganec} " +
            $"кг \r\nВремя работы доменной печи: {_resultPech} часов \r\nВремя работы конвертера: {_resultConvert} часов" +
            $" \r\nВремя работы прокатного стана: {_resultProkat} часов \r\nОбщая прибыль: {_resultRub} руб.\r\n");
    }
}
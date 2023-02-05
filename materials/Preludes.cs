﻿using System;

namespace fullRandomEHWPF.materials
{
    public static class Preludes
    {
        public static String[][] PreludesArray = new String[9][];
        public static void InitializingThePreludesArray()
        {
            PreludesArray[0] = new String[] { };
            PreludesArray[1] = new String[] { };

            PreludesArray[2] = new String[6]
            {
                "Пророк из антарктиды", "Начало конца", "Ключ к спасению", "Слухи с севера", "Последняя жертва", "Непокорная жертва"
            };
            PreludesArray[3] = new String[4]
            {
                "Парад светил", "Приближается буря", "Данвический ужас", "Тёмное благословение"
            };
            PreludesArray[4] = new String[6]
            {
                "Эпидемия", "Зов Ктулху", "Под пирамидами", "Литания секретов", "Призрак из прошлого", "Решительные меры"
            };
            PreludesArray[5] = new String[4]
            {
                "Грехи прошлого", "Король в жёлтом", "Претворить слабость в силу", "Сокровища серебрянных сумерек"
            };
            PreludesArray[6] = new String[6]
            {
                "Интенсивное обучение", "Шпион среди нас", "Сны об ином мире", "Нечестивые близнецы Черной Козы", "Паутина между мирами", "Предначертано звёздами"
            };
            PreludesArray[7] = new String[4]
            {
                "Цена известности", "Вы знаете, что должны сделать", "Конец человечества", "Апокалипсис грядёт"
            };
            PreludesArray[8] = new String[10]
            {
                "В тёмной-тёмной комнате", "Помощь старших богов", "Звёзды заняли свои места", "В пролом", "Архивы", "Армия Тьмы", "Отец Змей", "Предместник внешних Богов", "Искушение", "Удивительные диковинки"
            };

        }
    }
}
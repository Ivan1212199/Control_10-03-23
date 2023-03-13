Задача :

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


Описание алгоритма решения:

Сначало объявляется два массива: изначальный и вторый такой же длины. Потом метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия, если "да" элемент первого массива заносится в "ArrayTwo[i]" элемент второго массива. Переменная "ArrayTwo[i]", чтобы поочередно закидывать из первого массива во второй. После присвоения увеличивается переменная "ArrayTwo[i]" на 1 и возвращается к циклу for в котором "i" увеличивается на 1. И так проверяется до конца.

Графическое представление метода в файле "Shems.drawio".

Реализация алгоритма по пути "Task/Program.cs".
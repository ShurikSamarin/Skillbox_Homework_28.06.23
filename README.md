# Skillbox_Homework_28.06.23
# 5.5 Практическая работа
Цель практической работы
Закрепить знания по использованию методов. 


Что входит в работу
Метод разделения строки на слова.
Перестановка слов в предложении.

# Задание 1. Метод разделения строки на слова
Что нужно сделать
Пользователь вводит в консольном приложении длинное предложение. Каждое слово в этом предложении отделено пробелом. Создайте метод, который в качестве входного параметра принимает строковую переменную, а в качестве возвращаемого значения — массив слов. После вызова этого метода программа вызывает второй метод, который выводит каждое слово в отдельной строке. Метод должен выглядеть так: static string[] SplitText(string text), где text — это строка, которую необходимо разделить.

Советы и рекомендации
Для реализации этой программы можно написать алгоритм разделения на слова самостоятельно, используя цикл. Также можете использовать метод string.Split(‘ ’);. Подробнее о нём говорится на странице документации Microsoft.
Для названия методов используйте CamelCase, когда каждое следующее слово начинается с заглавной буквы. Например, метод с именем GetPositiveRandomInt возвращает положительное целое случайное число. По такому же принципу следует называть и свои методы.
В программе не должно быть глобальных переменных. Все данные между методами должны передаваться через параметры и возвращаемые значения.
Что оценивается
В программе, помимо основного метода main, присутствует два других метода, которые вызываются в теле метода main. 
Названия методов соответствуют тому, что они делают: разделяют или выводят данные.

# Задание 2. Перестановка слов в предложении
Что нужно сделать
Пользователь вводит в программе длинное предложение. Каждое слово отделено пробелом. После ввода пользователь нажимает клавишу Enter. Необходимо создать два метода:

первый разделяет слова в предложении;
второй меняет эти слова местами (в обратной последовательности). 
Учтите, что один метод вызывается внутри другого метода, то есть в методе main вызывается метод c сигнатурой ReversWords (string inputPhrase). Внутри этого метода вызывается метод по разделению входной фразы на слова. Метод должен выглядеть так: static string Reverse(string text), где text — это предложение, в котором необходимо поменять местами слова.

Советы и рекомендации
Для сложения строк можно использовать конкатенацию строк. Выражение вида ResultString += NewString + “ ” добавит к текущей строке, которая представлена переменной ResultString, новую строку из переменной NewString, а также пробел к концу строки. 
Для реализации алгоритма разделения строки на слова можно воспользоваться рекомендациями из задания 1.
В программе не должно быть глобальных переменных. Все данные между методами должны передаваться через параметры и возвращаемые значения.
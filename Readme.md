Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []


1. Ввод массива осуществляется пользователем с клавиатуры, с использованием знака ',' в качестве разделителя. 

2. Формирование нового массива реализет процедура "cutTheArray", которая принимает исходный массив и число символов, которое не должны превышать строки. 

3. При выполнении метода производится удаление пробелов, возможных при вводе массива. Далее идет "склейка" в строку искомых элементов с разделителем ",".  

4. На выходе процедура возврящает из получившейся строки новый массив строк, длина которых не превышает заданную в процедуре.

5. Для вывода входящий и искомый массивы преобразуются в строку, с помощью функции Join.
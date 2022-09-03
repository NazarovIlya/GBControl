# Описание решения

Задача реализована с помощью трех методов:
- InputArray(param);
- ArraySort(param);
- PrintArray(param);

## InputArray()
>С помощью данного метода получаем значения типа string, введенные пользователем.

## ArraySort()
>Данный метод формирует запрашиваемый условием задачи массив строк.

string[] ArraySort(string[] array)

{

    int count = 0; // инициализируем счетчик
    for (int i = 0; i < array.Length; i++)
    {
        
        
        if (array[i].Length <= 3) // проверяем элемента типа string
            count++; // получаем количество элементов длинной не более трех символов
    }
    string[] newArray = new string[count]; //создаем новый массив нужной длинны
    int k = 0; // счетчик для перебора элементов нового массива
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[k] = array[i]; // записываем значение строки длинной не более 3 символов в новый массив
            k++; 
        }

    }
    return newArray; // возвращаем полученный массив
}

## PrintArray(param);
>Метод для печати массива строк.

Хеш коммита кода решения задачи в первом варианте:
efc6070b89e2a431d669ff4b85817841e2dc33c2

[Блок-схема первого варианта решения](https://drive.google.com/file/d/1GH0nNdV9DThZM98aqDeGglONXiidjV0L/view?usp=sharing)

[Блок-схема ОСНОВНОГО варианта решения](https://drive.google.com/file/d/18ZIeI2oTmoojnJSarAgGw4ug4STewyB5/view?usp=sharing)
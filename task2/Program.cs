// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int day_numbers = int.Parse(Console.ReadLine());

switch(day_numbers)
{
    case 1:
        Console.Write("Это понедельник.");
        break;
    case 2:
        Console.Write("Это вторник.");
        break;
        
    case 3:
        Console.Write("Это среда.");
        break;   

    case 4:
        Console.Write("Это четверг.");
        break; 

    case 5:
        Console.Write("Это пятница.");
        break;

    case 6:
        Console.Write("Это суббота.");
        break;

    case 7:
        Console.Write("Это воскресенье.");
        break;

    default:
        Console.Write("В неделе всего семь дней.");
        break;
}


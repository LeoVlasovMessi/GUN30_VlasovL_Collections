using Collections;
using System.Threading.Tasks;

Console.WriteLine("Выберите номер задачи (от 1 до 3): ");
Int32.TryParse(Console.ReadLine(), out int task);
if (task>=1 && task<=3)
{
    switch (task)
    {
        case 1:
            var task1 = new ListTask();
            task1.TaskLoop();
            break;
        case 2:
            var task2 = new DictionaryTask();
            task2.TaskLoop();
            break;
        case 3:
            var task3 = new DoubleList();
            task3.TaskLoop();
            break;
    }
}
else Console.WriteLine("Неверно выбрана задача. Попробуйте заново");
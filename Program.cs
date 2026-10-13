PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader() {
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("0_0");
}

void PrintFooter() {
    Console.WriteLine(">_<");
    Console.WriteLine("   Конец программы");
    Console.WriteLine("X_X");
    Console.WriteLine("Дата формирования отчёта: 13.10.2026");
}


void PrintStudentCard(string name, int age, string group) {
    Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group}");
}

PrintStudentCard("Егор", 18, "252");
PrintStudentCard("Валерия", 17, "251");


double averageGrade = 4.6; 
double result; 

if (IsEligibleForBonus(averageGrade)) {
    result = CalculateScholarship(2000, 15);
} else {
    result = CalculateScholarship(2000, 0);
}

Console.WriteLine(result);

double CalculateScholarship(double baseAmount, double bonusPercent) {
    return baseAmount + baseAmount * bonusPercent / 100;
}

bool IsEligibleForBonus(double averageGrade) {
    return averageGrade >= 4.5;
}



double CalculateAverageGrade(int[] grades) {
    int sum = 0;
    foreach (int grade in grades) {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades){
    int count = 0;
    foreach (int grade in grades) {
        if (grade == 5) {
            count++;
        }
    }
    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);
Console.WriteLine(average);
Console.WriteLine(fives);


class Program {
    static void Main() {
        Console.WriteLine(Add(2, 3));       // вызовет первый вариант: int Add(int, int) -> 5
        Console.WriteLine(Add(2.5, 3.5));   // вызовет второй вариант: double Add(double, double) -> 6.0
        Console.WriteLine(Add(2, 3, 4));    // вызовет третий вариант: int Add(int, int, int) -> 9
    }

    static int Add(int a, int b) {
        return a + b;
    }

    static double Add(double a, double b) {
        return a + b;
    }

    static int Add(int a, int b, int c) {
        return a + b + c;
    }
}


// /*
// Задача Б. Напишите метод PrintPerson(string name, int age),
// выводящий информацию о человеке, и вызовите его для 
// двух-трёх разных людей.
// */
void PrintPerson(string name, int age) {
    Console.WriteLine($"Имя: {name} Возраст: {age}");
}
PrintPerson("София", 15);
PrintPerson("Саша", 22);

// /*
// Задача Г. Напишите метод int FindMax(int[] numbers), 
// возвращающий максимальное число массива.
// */
int FindMax(int[] numbers) {
    int max = 0;
    foreach (int number in numbers) {
        if (number > max) {
            max = number;
        }
    }
    return max;
}
int[] numbers = {1,2,3,7,5,8};
Console.WriteLine(FindMax(numbers));


Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname)) {
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// /*
// Вариант 6. int CountVowels(string word) — возвращает 
// количество гласных букв в слове.
// */
int CountVowels(string word) {
    int count = 0;
    string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
    foreach (char letter in word) {
        if(vowels.Contains(letter)){
            count++;
        }
    }
    return count;
}
Console.WriteLine(CountVowels("Компьютер"));

// /*
// Вариант 9. bool ContainsValue(int[] numbers, int target) — возвращает true, 
// если искомое значение есть в массиве (используйте линейный поиск внутри метода).
// */
bool ContainsValue(int[] numbers, int target) {
    foreach (int number in numbers) {
        if (number == target) {
            return true;
        }
    }
    return false;
}
int[] numbers = {1,2,3,4,5,6,7,8,9,10};
bool result = ContainsValue(numbers, 7);
Console.WriteLine(result);

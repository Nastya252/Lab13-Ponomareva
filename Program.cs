// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
//     Console.WriteLine("Дата формирования отчёта: 13.10.2026");
// }


void PrintStudentCard(string name, int age, string group) {
    Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group}");
}

PrintStudentCard("Егор", 18, "252");
PrintStudentCard("Валерия", 17, "251");


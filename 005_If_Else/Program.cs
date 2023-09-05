Console.Write("Введите имя пользователя: ");
string name = Console.ReadLine();

if(name.ToLower == "маша"){
    Console.Write("Ура! Это же Маша!");
}else{
    Console.Write("Привет, "+name);
}

using System;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;


namespace projectCourse;


class Program
{
    
    public static void Main()
    {
        Console.WriteLine("Hello!");


        // Это не удалять
        // Вот эти команды добаляют файл в репозиторий

        // git add *.cs Добавляет все файлы у которых расширение .cs 
        // git status Статистика
        // git commit -m ""  Коммит
        // git rm -r --cached . Удаляет вообще всё 
        // git rm --cached *.cs Удаляет все файлы у которых расширение .cs 
        // git add . Добавляет всё в локальный репозиторий
        // git branch forum Я создаю новую ветку с названием forum
        // git checkout forum Я перешел на ветку с названием forum
        // git checkout -b forum Я создаю и сразу перехожу на новую ветку
        // git merge forum Находясь на основной ветке master я присоединяю к ней ветку forum

        // Тут идет подключение к удаленному репозиторию с названием origin
        // git remote add origin https://github.com/MrakoBEScom/csharp.git

        // Я отключаюсь от удаленного репозитория с названием origin
        // git remote remove origin

        // Это команда выгружат ветку master на удаленный репозиторий origin
        // git push -u origin master

        // Копирует весь репозиторий в выбранную папку
        // git clone https://github.com/MrakoBEScom/csharp.git

        // Cкачивает последнюю версию проекта
        // git pull
    }




}
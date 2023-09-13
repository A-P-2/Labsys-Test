# Labsys-Test
![image](https://github.com/A-P-2/Labsys-Test/assets/57561034/1c369450-4598-4f3d-bcaa-6d3b5eeb9b54)

В папке "Labsys Project" находится исходный проект, написанный на Unity 2022.3.8f1. 
В файле "Labsys Package.unitypackage" содержится всё тоже самое, так что достаточно скачать только этот файл.
В папке "Labsys Build" находится сборка проекта

## Классы
Все классы находятся в папке "Labsys Project/Assets/Scripts/". Для реализации тестового задания были спроектированы следующие классы:
* ObjectInfo - содержит информацию об отдельном объекте (название, описание, характеристики, 3D-модель).
* ObjectsManager - содержит массив всех объектов. Позволяет получить множество названий всех объектов, а также подробную информацию (объект класса ObjectInfo) конкретного объекта по его названию.
* ListManager - класс для работы со списком объектов, выводимом на экран. Для каждого объекта создаёт отдельную кнопку в списке, и к каждой кнопке привязывает функцию, передаваемую извне.
* InfoManager - класс для вывода информации о конкретном объекте. Данный класс задействуется как для вывода описания, так и для вывода характеристик.
* UIManager - основной класс пользовательского интерфейса. Связывает воедино работу списка объектов (ListManager), вывода информации (InfoManager) и самих объектов (ObjectsManager).
* Rotator - класс для вращения 3D-модели, отображаемой на экране (не является частью тестового задания, добавил просто для красоты).

## Объекты
Объекты находятся в папке "Labsys Project/Assets/ScriptableObjects/Objects". В проекте присутствует 2 вида объектов разных цветов: кубы и цилиндры. У всех кубов и у всех цилиндров одинаковые описания и характеристики. Такое количество объектов было реализовано только для того, чтобы более наглядно продемонстрировать работу окна "Добавить объект" - когда объектов становится слишком много, автоматически появляется скроллер.
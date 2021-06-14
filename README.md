Backend-практикум от Tados
==========================

Описание предметной области
---------------------------

- Есть животные, у них есть клички и тип. Не может быть 2-х животных одного типа с одинаковыми кличками.
- Животные бывают разные — кошки и собаки.
- Есть породы кошек и породы собак. У пород есть название. Не может быть 2-х пород одного типа с одинаковыми названиями.
- Кошки и собаки помимо кличек имеют породы соответствующего типа.
Помимо этого у кошек есть вес, а у собак длина хвоста.
- Есть корм, у него есть название и имеющееся у нас его количество.
- Корм бывает для кошек, бывает для собак. Не может быть 2-х кормов для животного одного типа с одинаковыми названиями.
- Животных можно кормить, кошек кошачьим кормом, собак собачьим.
- При этом мы должны знать кого, когда, чем и в каком количестве кормили.
- При кормлении уменьшается кол-во корма.
- Кол-во имеющегося у нас корма может быть увеличено.

Функциональные требования
-------------------------

Необходимо реализовать Web API приложение со следующим набором методов:
1. Добавление породы
2. Получение пород (с фильтром по типу животного и поиском по названию)
3. Добавление корма
4. Получение кормов (с фильтром по типу животного и поиском по названию)
5. Добавление животного
6. Получение списка животных (с фильтром по типу и поиском по кличке)
7. Получение животного (полная информация, с историей кормлений)
8. Кормление животного (кого, чем и в каком количестве)
9. Добавление кол-ва существующего корма

Работа с проектом
-----------------

Для запуска проекта требуется [.NET SDK 5.0](https://dotnet.microsoft.com/download/dotnet/5.0).
После клонирования или скачивания репозитория в папке проекта достаточно выполнить:

```dotnet run```

После чего приложение будет развёрнуто по адресу [http://localhost:5000](http://localhost:5000).

Полезные ссылки
---------------

1. [Сервер Discord](https://discord.gg/f6n7gTCg) (обсуждения)
1. [Чат в Telegram](https://t.me/dotnet_prm) (для вопросов и решений)
1. [Канал YouTube](https://www.youtube.com/channel/UCuWxuYKNP1shS3OLKlZwGIw) (записи практикума)
1. [Паблик Tados ВК](https://vk.com/tados_life) (анонсы митапов)
# RPG

#ENGLISH

The !README folder contains a gameplay video of the game

Implemented features in the project:
- Player
  - joystick control
  - attacking enemies within a given radius
  - changeable parameters when putting on new equipment (damage, running speed, defense, critical damage%, critical damage chance%)
  - appropriate animations
  
- Enemies
  - several types of enemies with their own, flexibly customizable characteristics
  - implemented several enemy states (Patrol, Pursuit, Attack, Search for a target)
  - attack radius, search radius, pursuit are flexibly set
  
- Quests
  - Saved, implemented via ScriptableObject
  - Main quests
    sequential quests that lead the character to the main goal
  - Secondary quests
    quests that are taken from NPC characters. Each character can have multiple consecutive quests
  - Highlighting a quest
    when clicking on the main or secondary quest, a beacon will appear that will lead the player to the place where the quest is being performed.
    
- Inventory (Store equipment knocked out of mobs or found on the map)
  - Preview. When choosing a certain equipment, it is displayed how its performance will be reflected in the overall statistics of the player
  - The worn item is displayed on the player's model in the inventory itself
  - removal of an object
  - deleting an unnecessary item
  
- Drop items (when killing an enemy)
  - Parameters (damage, running speed, defense, critical damage%, critical damage chance%) that affect the hero's abilities
  - Rarity (Common, Uncommon, Rare, Epic, Legendary)
  - Tier (tier1, tier2, tier3, tier4, tier5)
  - Type (Weapon, Helmet, Arms, Torso, Legs, *Potion)
  - Randomness:
    - drop with a certain chance of each rarity
    - corresponding parameter values ​​for each Tire
    
- Tutorial
  - possible repeat
  
- Developer tools
  - the ability to set the Player's Equipment before starting the game
  - the ability to set Active Quests before starting
  - enable/disable saving progress

#Русский

В папке !README находится видео геймплея игры

В проекте реализованы:
- Игрок
  - управление джойстиком
  - атака врагов в задаваемом радиусе
  - изменяемые параметры при надевании нового снаряжения(урон, скорость бега, защита, критический урон%, шанс критического урона%)
  - соответствующие анимации
- Враги
  - несколько видов врагов со своими, гибко настраиваемыми характеристиками
  - реализованы несколько состояний врагов ( Патруль, Преследование, Атака, Поиск цели)
  - радиус атаки, радиус поиска, преследования гибко задаются
  
- Квесты
  - Сохраняются, реализованы через ScriptableObject
  - Главные квесты
    последовательные квесты, которые ведут персонажа к главной цели
  - Второстепенные квесты
    квесты, которые берутся у нпс-персонажей. У каждого персонажа может быть несколько последовательных квестов
  - Выделение квеста
    при нажатии на главный или второстепенный квест, появится маячек, который приведет игрока к месту, где выполняется квест.
    
- Инвентарь (Хранит в себе снаряжение, выбитое из мобов или найденное на карте)
  - Предпросмотр. При выборе определенного снаряжение, отображается как его показатели отразятся на общей статистике игрока
  - Надетый предмет, отображается на модельке игрока в самом инвентаре
  - снятие предмета
  - удаление ненужного предмета
  
- Выпадение предметов (при убийстве врага)
  - Параметры (урон, скорость бега, защита, критический урон%, шанс критического урона%), которые отражаются на способностях героя
  - Редкость(обычный, необыйчный, редкий, эпический, легендарный)
  - Tier (тир1, тир2, тир3, тир4, тир5)
  - Тип (Оружие, Шлем, Руки, Торс, Ноги, *Зелье)
  - Рандомность:
    - выпадение с определенным шансом каждой редкости
    - соответствующие значения параметров для каждого Тира
- Туториал
  - возможный повтор
  
- Инструменты разработчика
  - возможность перед запуском игры задавать Снаряжение Игрока
  - возможность перед запуском задавать Активные Квесты
  - включать/выключать сохранение прогресса
  
   
  
  
     

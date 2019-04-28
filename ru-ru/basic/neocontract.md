# NeoContract White Paper

## Предисловие

Смарт-контрактом является любая компьютерная программа, которая выполняет предварительно запрограммированные условия реализации контракта в автоматическом режиме. Идея смарт-контракта стара как сам Интернет: впервые она была предложена криптографом Ником Сабо в 1994. В связи с нехваткой надежной среды для реализации программы смаркт-контракты используются не так активно.

В 2008 человек по имени Сатоси Накамото выпустил Bitcoin, заложив тем самым фундамент для создания блокчейна. В рамках Bitcoin-блокчейна Накамото использует набор сценарных языков, которые позволяют пользователям достичь бОльшую свободу действий в контроле над личными счетами и переводами. Bitcoin Накамото стал, в конечном счете, прообразом системы смарт-контракт, базирующейся на технологии блокчейна.  

В 2014 тинейджер Виталик Бутерин выпускает Ethereum (Эфириум), а вместе с ним тьюринг-полную систему смарт-контракт, в основе которой так же лежит принцип блокчейна, и которая может быть использована для создания огромного числа децентрализованных блокчейн-приложений.

Блокчейн NEO – это цифровой актив и платформа приложений, предоставляющая новую систему смарт-контракт, NeoContract. Суть платформы NEO заключается в том, что сеть способна обеспечивать выполнение различных функций, таких как поддержка цифровых активов, NeoAsset, и цифровой идентичности, NeoID. Такие возможности сети позволяют пользователям заниматься разными видами цифрового бизнеса, не ограничиваясь только выпуском собственных токенов в блокчейне.

Данная статья описывает функциональные возможности NeoContract, а также освещает информацию не технического характера. Техническую документацию см. на: [docs.neo.org](http://docs.neo.org).

## Технические характеристики

### Детерминированность

Если программа может работать на разных компьютерах или на одном и том же компьютере, но в разное время, обеспечивая при этом вывод одних  и тех же выходных данных при наличии одних и тех же входных данных (и наоборот), то данная программа является детерминированной.

Блокчейн – это одновременно и вычислительный метод, и многопользовательское хранилище, данные которого находятся в пределах распределенной системы и являются результатом надежных вычислений. Данное хранилище отвечает всем требованиям безопасности. Смарт-контракты реализуются в рамках многоузловой распределенной блокчейн-сети. Если смарт-контракт не является детерминированным, то результаты разных узлов могут оказаться не согласованными. В итоге, консенсус между узлами становится невозможным, и сеть приобретает стагнационный характер. Таким образом, при разработке системы смарт-контракт необходимо исключить любые факторы, способные привести к подобной недетерминированности.  

#### Время

Система-время – это широко распространенная функция системы,  которая может быть активно применена в определенных время зависимых процедурах контракта. Однако система-время – это функция недетерминированной системы, то есть получение единого и точного времени в распределенной системе крайне затруднительно, поскольку результаты узлов не будут согласовываться друг с другом. NeoContract осуществляет блочный системный вызов, который воспринимает весь блокчейн как сервер временных меток и получает временную метку всякий раз, когда сгенерирован новый блок. В среднем, сеть NEO генерирует новый блок каждые 15 секунд, то есть контракт работает примерно в то же время, что и последний блок-время, плюс-минус 15 секунд.

#### Случайность

Многие программы смарт-контракт, такие как контракты азартных и маленьких игр, используют функции случайного числа. Однако, функция случайного числа -  это типичная недетерминированная функция, и каждый системный вызов будет получать разные результаты. Распределенная система предлагает множество способов решения данной проблемы: во-первых, одно и то же случайное начальное число может быть использовано для всех узлов, то есть обратная последовательность всей случайной функции является детерминированной, но данный метод позволяет узнать случайный результат заранее, что значительно уменьшает практическую ценность случайного числа. В качестве еще одного возможного решения можно предложить следующее: чтобы сгенерировать случайные числа, узлы должны слаженно взаимодействовать друг с другом. Для получения действительно случайного числа необходимо применить криптографические техники. Однако недостатком данного решения являются крайне плохая производительность и дополнительная потеря пропускной способности.  Для генерации случайного числа можно воспользоваться также услугами централизованного провайдера, который смог бы гарантировать согласованность и производительность. Тем не менее,  этот подход имеет очевидный минус: пользователи должны безоговорочно доверять централизованному провайдеру числа.


Существует два способа генерации случайного числа в NEO:

1. При генерации блока, узел консенсуса достигает консенсуса по случайному числу и заносит его в поле Nonce нового блока. Контракт-программа может с легкостью получить случайное число любого блока, обращаясь к полю Nonce.

2. Контракт-программа может использовать хеш-значение блока в качестве генератора случайного числа, поскольку ему присуща определенная доля случайности. Данный метод может быть использован для получения условно случайного числа (weak random number).

#### Источник данных

Если программа получает данные во время своей реализации, а источник данных предоставляет недетерминированные данные, то программа может так же стать недетерминированной. Например, используя разные IP адреса для получения топ-10 поисковых результатов для определенного ключевого слова, разные поисковые системы могут дать разные результаты и в разном порядке сортировки.

NEO обеспечивает смарт-контракты двумя типами ресурсов детерминированных данных:

- **Регистр блокчейна**

   Благодаря совместимым сервисам процедура контракта имеет доступ ко всем данным цепи, включая полные блоки, транзакции и каждое из их полей. Данные в блоках детерминированы и непротиворечивы, поэтому смарт-контрактам гарантирован безопасный доступ к ним.

- **Пространство хранения контракта**

   Каждый контракт, развертываемый в сети NEO, имеет частную зону хранения, которая доступна только данному контракту. Механизм консенсуса NEO обеспечивает согласованность статуса хранения каждого узла в сети.

В случае, когда необходим доступ к данным вне блокчейна, NEO не позволит напрямую взаимодействовать с ними. Для того чтобы смарт-контракты смогли получить доступ к данным, их необходимо перенести в блокчейн NEO посредством транзакций, а затем в один из упомянутых выше источников данных.

#### Вызов контракта

Смарт-контракты в NeoContract могут вызывать друг друга, но они не могут быть вызваны рекурсивно. Рекурсия возможна только в пределах текущего контракта. При этом вызовы смарт-контрактами друг друга должны иметь статический характер:  цель не может быть определена во время реализации смарт-контракта. Таким образом, поведение программы и характер ее вызовов полностью определенны еще до ее выполнения. Основываясь на всем вышесказанном, можно предложить динамически разбивать смарт-контракты на части, что позволит достичь параллельного выполнения программы.

### Высокая производительность

Среда выполнения смаркт-контракта играет ключевую роль в его производительности. При анализе производительности любой среды выполнения программы следует обратить внимание на два основополагающих критерия:

1. Скорость выполнения команды
2. Скорость запуска самой среды выполнения программы 

Для смарт-контрактов среда выполнения программы зачастую намного важнее, чем скорость выполнения команды. Чтобы определить команды, смарт-контракты работают больше с логическими операциями ввода-вывода, которые позволяют оптимизировать выполнение данных команд. При каждом вызове смарт-контракт должен запускать новую виртуальную машину/ контейнер. Таким образом, именно, скорость выполнения самой среды (запуск виртуальной машины/ контейнера) в значительной мере влияет на производительность системы смарт-контракт.

В качестве среды для выполнения смарт-контракта NEO использует легкую NeoVM (виртуальная машина NEO), поскольку она требует мало времени на запуск и расходует небольшой объем ресурсов. Все это делает ее превосходной средой для реализации смарт-контрактов. Используя компиляцию и кеширование хот-спота, смарт-контракты совместно с JIT (динамический компилятор) могут значительно повысить эффективность виртуальных машин.

### Масштабируемость

#### Высокий параллелизм и динамическое сегментирование

Когда речь идет о масштабируемости системы, необходимо уточнить, о какой именно, поскольку масштабируемость может быть как вертикальной, так и горизонтальной. Первая связана с оптимизацией процесса, она позволяет системе выжать максимум из оборудования. Если брать на вооружение этот подход, то возможности, которыми обладает система, крайне ограничены, потому что обрабатывающая способность последовательной системы зависит от аппаратного ограничения каждого конкретного устройства. Когда нам нужно масштабировать систему, возможно ли превратить последовательную систему в параллельную? Теоретически, все, что нам потребуется, это увеличить количество устройств, и тогда мы получим почти неограниченную масштабируемость. Возможно ли в принципе неограниченное масштабирование в распределенных блокчейн-сетях? Или, другими словами, может ли блокчейн реализовывать программы в параллельном режиме?

Блокчейн – это распределенный регистр, записывающий различные данные о состоянии, а также правила, регулирующие изменения в состоянии данных. Смарт-контракты используются в качестве носителей, на которых записаны эти правила. Блокчейны могут выполнять программы в параллельном режиме только в том случае, когда несколько смарт-контрактов реализовываются одновременно, но не последовательно. Иными словами, если контракты не взаимодействуют друг с другом, или если один из контрактов не изменяет те же данные о состоянии и в то же время, что и второй контракт, то эти контракты выполняются непоследовательно и могут быть реализованы одновременно. В противном случае смарт-контракт может быть выполнен только в последовательном порядке, а сеть окажется не способной к горизонтальному масштабированию. 

Взяв за основу проведенный выше анализ, мы можем с легкостью обеспечить системы смарт-контракт "неограниченным масштабированием". Все что нам потребуется, так это установить простые правила:

 * **Смарт-контракт может изменять только запись о состоянии контракта, к которому он относится**

 * **В одной партии транзакций (блоке) контракт может быть выполнен только один раз**

Таким образом, все смарт-контракты могут быть реализованы в параллельном режиме, поскольку последовательность выполнения программы не влияет на конечный результат. Тем не менее, если «Смарт-контракт может изменять только запись о состоянии контракта, к которому он относится», то это означает, что контракты не могут вызывать друг друга. Контракт – это по сути изолированный остров, то есть, если «В одной партии транзакций (блоке) контракт может быть выполнен только один раз», то цифровой актив, выпущенный смарт-контрактом, может работать только с одной транзакцией на блок. Все это очень сильно отличается от первоначальной концепции «умного» контракта, который перестает теперь быть «умным». Наши же цели разработки включают в себя как вызов между контрактами в обоих направлениях, так и многократное выполнение одного и того же вызова и в одном и том же блоке.

К счастью, смарт-контракты в NEO выполняют статические вызовы, при этом цель вызова не может быть определена во время выполнения программы. Благодаря этому поведение программы и характер вызовов можно определить еще до ее реализации. Необходимо, чтобы каждый контракт мог открыто указывать на другие контракты, которые, скорее всего, будут вызваны. Это необходимо для того, чтобы операционная среда могла рассчитать законченное дерево вызовов до выполнения процедуры контракта и последовательного исполнения контрактов, опираясь на дерево вызовов. Контракты, которые могут изменять одну и ту же запись о состоянии, выполняются последовательно в пределах одного сегмента, при этом несколько сегментов могут затем быть выполнены в параллельном режиме.   

#### Низкая связанность

Связанность – это степень зависимости между двумя или более объектами. Система NeoContract использует принцип низкой связанности, реализованный в NEOVM, и взаимодействует с данными вне блокчейна посредством слоя совместимых сервисов. В результате, увеличивая API совместимых сервисов, можно усовершенствовать функции смарт-контракта.

## Использование контракта

### Верификационный контракт 

В отличие от системы учетных записей в Bitcoin, использующей открытые ключи, система NEO применяет контрактную систему учетных записей. Каждая учетная запись в NEO соответствует верификационному контракту, хеш-значением которого является адрес учетной записи. Согласно своей программной логике верификационный контракт контролирует владение учетной записью. При передаче данных с учетной записи сначала вам потребуется выполнить верификационный контракт. Контракт верификации принимает ряд параметров (как правило, это цифровая подпись или другие критерии) и возвращает булево значение после верификации, сообщая тем самым системе об успешно прошедшей процедуре верификации.

Пользователь может заранее развернуть верификационный контракт в блокчейне или опубликовать содержание контракта напрямую в транзакцию во время передачи данных.

### Прикладной контракт

Прикладной контракт запускается специальной транзакцией, которая имеет доступ к системе, может изменять ее глобальное состояние, а также приватное состояние контракта (зону хранения) во время реализации программы. Например, вы можете создавать глобальный цифровой актив в контракте, голосовать, сохранять данные и даже динамически реализовывать новый контракт во время работы старого.

Согласно инструкции за выполнение прикладного контракта взимается дополнительная плата. Когда комиссия за проведение транзакции израсходована, выполнение контракта будет остановлено, а все изменения состояния вернутся к прежнему значению. Успешная реализация контракта не влияет на валидность транзакции.

### Функциональный контракт

Функциональный контракт необходим для реализации открытых или общеприменимых функций, которые могут быть вызваны другими контрактами. Код смарт-контракта может быть использован повторно, что позволяет разработчикам писать логику предметной области с возрастающей степенью сложности. Во время развертывания каждый функциональный контракт может выбрать частную область хранения, с которой можно считывать или в которую можно записывать данные из последующих контрактов. Таким образом достигается постоянство состояния. 

Функциональный контракт должен быть предварительно развернут в вызываемой цепи, а затем удален из нее с применением системной «самоликвидирующейся» функции, которая не будет использована в дальнейшем (ее частная область хранения будет так же уничтожена). Пока старый контракт не ликвидирован, его данные могут автоматически мигрировать в другой субконтракт, используя контрактные инструменты миграции. 

## Виртуальная машина 

### Виртуальные аппаратные средства

NEOVM предоставляет следующий слой виртуального аппаратного обеспечения, необходимого для выполнения смарт-контрактов:

 * **Центральный процессор**

   Центральный процессор (ЦП) отвечает за чтение и последовательное выполнение команд в контракте согласно функции управления потоком команд, арифметическим и логическим операциям. С внедрением JIT (динамического компилятора) функционал ЦП может быть расширен, что позволит повысить эффективность выполнения команд.

 * **Стек вызовов**
   
   Стек вызовов используется для того, чтобы контекстная информация о выполнении программы была доступна при каждом вызове функции, то есть для того, чтобы программа могла выполняться в текущем контексте после того, как функция закончила выполнение и возвращение.

 * **Стек вычислений**
   
   Все данные режима работы NEOVM хранятся в стеке вычислений. После выполнения различных команд стек производит вычисления по соответствующим  элементам данных операции. К примеру, при выполнении команд сложения, две операции, участвующие в сложении, исключаются из стека вычислений, и результат сложения поднимается на верхние позиции стека. Параметры функционального вызова должны быть рассчитаны согласно порядку в стеке, то есть справа налево. После успешного выполнения функции верхняя позиция стековой fetch-функции возвращает значение.

 * **Резервный стек**

  Когда вам нужно организовать или перегруппировать элементы в стеке, вы можете какое-то время хранить данные элементы в резервном стеке, а затем вернуть их на прежнее место.

### Набор инструкций

NEOVM предоставляет набор простых прикладных инструкций, предназначенных для создания программ смарт-контракт. В зависимости от своего функционального назначения команды можно разделить на следующие основные категории:

 * Инструкция константы
 * Инструкция управления процессом
 * Инструкция стековой операции
 * Инструкция строки
 * Инструкция логических операций
 * Инструкция арифметических операций
 * Криптографическая инструкция
 * Инструкция обработки данных

Стоит отметить, что набор инструкций NeoVM предоставляет ряд криптографических инструкций, таких как ECDSA, SHA и другие алгоритмы, предназначенные для оптимизации выполнения криптографических алгоритмов в смарт-контрактах. При этом команды манипуляции данными напрямую поддерживают массивы и сложные структуры данных.


### Слой совместимых (Interoperable) сервисов

Виртуальная машина, реализующая смарт-контракт, - это среда Sandbox, которая требует использования слоя совместимых сервисов в тех случаях, когда необходим доступ к данным вне Sandbox, или когда нужно, чтобы данные о среде выполнения были постоянными. В пределах слоя совместимых сервисов контракт NEO может открывать ряд системных функций и сервисов в программе смарт-контракта. Данные контракты можно вызывать и получать к ним доступ как к обычным функциям. Все функции системы выполняются в параллельном режиме, что решает проблему масштабируемости.

### Функция отладки

Зачастую разработка смарт-контрактов представляется сложной задачей вследствие нехватки хороших методов тестирования и отладки. NeoVM поддерживает отладку программы на уровне виртуальной машины, то есть вы можете задать точку останова в контрактном коде или же реализовать пошаговое однопроцессное выполнение программы. Благодаря низкой связанности между виртуальной машиной и блокчейном NeoVM можно напрямую интегрировать с различными IDE, которые будут выступать в роли тестовой среды, соответствующей  окончательной рабочей среде.

## Высокоуровневые языки программирования

### C#, VB.Net, F#

Разработчики могут использовать NeoContract практически для любого высокоуровневого языка, которым они хорошо владеют. К первой группе поддерживаемых языков относятся C #, VB.Net, F # и тд. Мы предоставляем компиляторы и плагины для того, чтобы компилировать данные высокоуровневые языки ​​в набор команд, поддерживаемых NeoVM. Поскольку компилятор ориентирован на язык MSIL (промежуточный язык Microsoft), то теоретически любой язык .Net может быть переведен в язык MSIL и поддержан напрямую.

Огромное число разработчиков владеют описанными выше языками, которые имеют к тому же очень развитую IDE. Разработчики смогут разрабатывать, генерировать, тестировать и отлаживать в Visual Studio, а также использовать такое преимущество как шаблоны разработки смарт-контрактов, предоставляемые нами.

### Java, Kotlin

Java и Kotlin входят во вторую группу поддерживаемых языков, для которых мы так же предоставляем компиляторы и IDE- плагины, ​​что позволяет разработчикам использовать языки виртуальной машины Java (JVM) для создания приложений NEO Smart Contract.

Java применяется повсеместно, а Kotlin стал недавно языком, который Google официально рекомендует для разработки операционной системы Android. Мы считаем, что, поддерживая эти языки, мы сможем существенным образом увеличить число разработчиков смарт-контрактов NEO.

### Другие языки

Благодаря дальнейшей разработке компилятора NeoContract будет поддерживать и другие высокоуровневые языки, основываясь на уровне их сложности. Вот некоторые из тех языков, которые будут поддерживаться системой:

 * C, C++, GO
 * Python, JavaScript

В будущем мы продолжим увеличивать список поддерживаемых  высокоуровневых языков. Наша цель заключается в том, чтобы более 90% разработчиков NEO, использующих NeoContract, смогли работать, не нуждаясь в изучении нового языка, и смогли, возможно, даже передавать код существующей бизнес-системы напрямую в блокчейн.

## Сервис

### Регистр блокчейна

Благодаря системным функциям, реализуемым совместимыми сервисами, смарт-контракты NEO могут получать для блокчейна NEO данные полного блока, включая полные блоки, транзакции и их поля, еще во время выполнения программы. Можно, в частности, запросить следующие данные:

 * Высота блокчейна
 * Заголовок блока, текущий блок 
 * Транзакции
 * Тип транзакции, атрибуты, входные и выходные данные и тд.

С помощью этих данных вы можете разрабатывать интересные приложения, такие как автоматические выплаты и смарт-контракты, реализуемые с применением алгоритма proof of workload.

### Цифровые активы

Благодаря совместимым сервисам, предоставляемым интерфейсом цифровых активов, смарт-контракты могут не только запрашивать  блокчейн NEO о свойствах и статистике различных цифровых активов, но и создавать новые во время выполнения программы. Цифровые активы, созданные смарт-контрактами, могут быть выпущены, переведены и проданы за пределами контракта. Они аналогичны начальным активам NEO, поэтому ими может управлять любой кошелек с ПО, совместимым с NEO. В указанный интерфейс входят следующие компоненты:

 * Запрос атрибута актива
 * Запрос статистики актива
 * Управление жизненным циклом актива: создание, внесение изменений, уничтожение и тд.
 * Управление активами: многоязычное имя, общие изменения, прецизионные изменения, смена администратора

### Постоянное хранение данных

Каждая программа смарт-контракта, развертываемая в блокчейне NEO, имеет свою приватную область хранения, которая доступна для чтения и записи только данному контракту. Смарт-контракты получают разрешение на любые операции над данными, доступными в приватной области хранения: их можно считывать, записывать, изменять и удалять. Данные хранятся в виде пары «ключ-значение» и реализуют следующие интерфейсы:

 * Обход всех хранящихся записей 
 * Возвращение к определенной записи согласно определенному ключу 
 * Изменение или создание новых записей согласно определенному ключу
 * Удаление записи согласно определенному ключу 

В общем и целом, контракт может считывать и записывать данные только со своего хранилища. Однако есть одно исключение: вызываемый контракт может получить доступ к хранилищу вызывающего клиента посредством междоменного запроса при условии, что вызывающий клиент прошел авторизацию. При этом контракт получает доступ к хранилищу субконтракта, который динамически реализуется в момент выполнения родительского контракта. 

Междоменные запросы предоставляют NeoContract возможности обширной библиотеки, которая позволяет вызывающей стороне управлять высокомасштабируемыми данными.

## Комиссии

### Комиссия за развертывание

Распределенная архитектура NEO обеспечивает высокую избыточность  емкости хранения, причем за пользование данной емкостью взимается плата. Развертывание смарт-контракта в сети NEO требует оплаты комиссии (в данный момент она составляет 500GAS), которую система взимает и записывает как свою прибыль. В дальнейшем размер комиссии будет устанавливаться в соответствии с текущими стоимостями операций в системе. Смарт-контракт, развернутый в блокчейне, может быть использован до тех пор, пока тот, кто развертывал данный контракт, не уничтожит его.

### Комиссия за выполнение 

NEO предоставляет надежную среду для реализации смарт-контрактов, а это в свою очередь требует значительных вычислительных ресурсов для каждого узла. Таким образом, пользователи должны платить за выполнение смарт-контрактов. Размер комиссии зависит от объема вычислительных ресурсов, использованных при каждом выполнении программы (цена указана в GAS). Если смарт-контракт не реализован по причине недостаточного количества GAS, то стоимость использованных ресурсов не возвращается. Данный подход позволяет защитить ресурсы сети от злонамеренных действий.

Большинство простых контрактов могут быть реализованы бесплатно (при условии, что стоимость выполнения контракта составляет менее 10 GAS), что позволяет значительно уменьшить расходы пользователя.

## Сценарии применения 

### Сверхпроводящие транзакции

Цифровые активы блокчейна требуют по сути своей некоторой формы ликвидности, а обычные транзакции типа «от точки до точки» не способны обеспечить ее в достаточной степени, в связи с чем появляется необходимость в трейдинговых сервисах. Обмен цифровыми активами можно разделить на две основные категории:

1. **Централизованный обмен:** пользователь сдает свои активы на хранение и затем размещает актуальные заказы на трейдинг на веб-сайте.
2. **Децентрализованный обмен:** трейдинговая система встроена в блокчейн; система предоставляет услуги согласования.

Централизованный обмен способен обеспечить очень высокую производительность и предложить широкий спектр услуг, но ему необходима  серьезная кредитная гарантия, иначе возникает угроза моральных рисков, таких как незаконное завладение фондами пользователя, мошеннические действия и тд. Децентрализованный обмен, напротив, не подвержен моральным рискам, но возможности взаимодействия с пользователем здесь крайне ограничены, а производительность системы имеет много узких мест. Существует ли способ объединить оба варианта и получить третий, вобравший в себя лучшее из двух? 

Таким третьим вариантом могут стать суперпроводящие транзакции: пользователям не надо сдавать активы на хранение, поскольку они могут использовать собственные активы в блокчейне во время трейдинга. Взаиморасчеты по транзакции завершаются в блокчейне, однако порядок согласования происходит вне цепи, его осуществляет централизованный обмен, который предоставляет услуги согласования. Поскольку процесс согласования происходит вне цепи, его эффективность аналогична централизованному обмену, при этом активы остаются под контролем пользователя. Обмен использует намерение пользователя реализовать услуги согласования (при этом исключена возможность моральных рисков, таких как незаконное завладение фондами пользователя, мошеннические действия и тд).

Сегодня сообщество NEO занимается разработкой смарт-контрактов для создания сверхспроводящих транзакций в блокчейне, таких как OTCGO.

### Смарт-фонд

Смарт-фонды, реализованные на базе блокчейн-технологии, имеют следующие преимущества: будучи децентрализованными, открытыми и прозрачными, они обладают бОльшей безопасностью и свободой чем традиционные фонды. Смарт-фонды участвуют в международной торговле, они открыты инвесторам со всего мира, благодаря этому нетривиальные проекты могут получать финансирование из любой точки земного шара.

Nest - это проект смарт-фонда, функционирующего на базе NeoContract. Он практически аналогичен проекту TheDAO, реализованному на базе Ethereum, но благодаря доработанным мерам безопасности Nest удалось избежать ошибок TheDAO (хакеры).

### Межцепочная совместимость

В обозримом будущем количество публичных, альянсных и частных цепей вырастет в тысячу раз. Эти изолированные блокчейн-системы станут своего рода обособленными островками со своей валютой и информацией, взаимодействие между ними будет полностью отсутствовать. Механизм межцепочной совместимости позволяет соединять многочисленные изолированные блокчейны, благодаря чему валюты из разных блокчейнов можно обменивать друг на друга, пользуясь преимуществами межсетевого пространства.

NeoContract поддерживает механизм межцепочной совместимости, гарантируя непротиворечивость межцепочного обмена активами, межцепочных распределенных транзакций, а также реализации смарт-контрактов в разных блокчейнах.

### Оракулы (Oracle)

Согласно народным сказаниям оракулы, будучи существами, обладающими сверхъестественными способностями, могли отвечать на ряд определенных вопросов. В рамках блокчейна оракулы открывают смарт-контрактам дверь во внешний мир, то есть позволяют им использовать информацию из реального мира в качестве условия выполнения контракта.

NeoContract не предоставляет такой возможности, как прямой доступ ко внешним данным (например, ресурсам Интернета), поскольку это приведет к недерминированности, а следовательно, несогласованности между узлами во время выполнения контракта. Реализация оракулов в NeoContract требует того, чтобы внешние данные были переданы в блокчейн доверенной третьей стороной, которая интегрировала бы эти потоки данных с регистром блокчейна, нивелируя тем самым риски недерминированности.

Надежной третьей стороной, упомянутой выше, может быть как человек, так и организация, которым обе стороны контракта доверяют в равной степени. Третьей стороной может стать также децентрализованный поставщик данных, экономически мотивированный на выполнение данной роли. NeoContract можно таким образом использовать в реализации подобных оракулов.

### Ethereum DAPP 

Bitcoin открыл эру блокчейна и электронных денег, а Ethereum – смарт-контрактов. Ethereum, пионер в реализации смарт-контратков с применением блокчейн-технологии внес большой вклад в проектирование, экономическую модель и техническую реализацию системы смарт-контракт. В то же время Ethereum-платформа работала со многими DAPPs (распределенные приложения), в чьи функциональные возможности входили соглашения по азартным играм, цифровые активы, электронное золото (e-gold), игровые платформы, медицинское страхование, платформы для знакомств и многие отрасли экономики. Теоретически все эти DAPP, так же как и приложение NEO, могут быть с легкостью реализованы на платформе NeoContract.
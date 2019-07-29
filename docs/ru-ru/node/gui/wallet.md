# Кошелек

Файл кошелька с расширением .json или .db3 хранит ссылку на ваши NEO, GAS и информацию о счете в базе данных. Этот файл крайне важен, поэтому он должен иметь хорошо защищенную резервную копию.

> [!Important]
>
> Потеря файла кошелька или его пароля приведет к потере ваших активов. Пожалуйста, удостоверьтесь в безопасном хранении файла кошелька. Не забывайте пароль кошелька.

## Создание базы данных кошелька

1. Щелкните кнопкой мыши по `Wallet`, `New Wallet Database`.

   ![image](../../../assets/gui_2.png)

2. Щелкните кнопкой мыши по `Browse`, чтобы выбрать место хранения файла кошелька, а затем задайте имя файла и щелкните кнопкой мыши по `Save`.

3. Введите `Password` и `Re-Password`, а затем сохраните свой пароль.

4. Щелкните кнопкой мыши по `OK` Кошелек, который по умолчанию имеет стандартный счет, успешно создан. 

   > [!Note]
   >
   > Из-за механизма изменения оставшаяся часть активов по умолчанию переводится на первый адрес, что создает необходимость в резервной копии соответствующих закрытого ключа и кошелька.

## Просмотр информации о кошельке 

### Счет

Щелкните правой кнопкой мыши по счету и выберите `View Private Key`, чтобы проверить информацию о нем:

- Адрес: эквивалент банковского счета или номера банковской карты; используется для получения активов во время транзакций.

- Закрытый ключ: 256-битное случайное число, которое пользователь хранит втайне от других. Ключ дает пользователю право собственности на данный счет и право собственности на активы из этого счета.

- Открытый ключ: Каждый закрытый ключ имеет соответствующий ему открытый ключ (Примечание: информацию об открытом и закрытом ключах можно просмотреть, щелкнув правой кнопкой мыши по адресу).

> [!Important]
>
> Ни при каких условиях закрытый ключ не должен быть передан другим лицам, в противном случае его разглашение может привести к потере ваших активов.

Вы также можете выполнить следующие операции, щелкнув правой кнопкой мыши по адресу счета:

| Function          | Description                                                  |
| ----------------- | ------------------------------------------------------------ |
| Create New Add.   | Создает новый адрес в кошельке                               |
| Import            | `Import from WIF`:  Импортирует соответствующий адрес в кошелек<br>`Import from Certificate:`Импортирует сертификат <br>`Import Watch-Only Address`： Импортировав  адрес другой стороны, который доступен только в режиме просмотра, вы можете отслеживать активы по этому адресу. |
| Copy to Clipboard | Копирует адрес                                               |
| Delete            | Удаляет адрес                                                |


### Активы

Щелкая кнопкой мыши по вкладке  `Asset`,  вы можете видеть активы счета, включая Assets (NEO, GAS, активы, созданные пользователем), тип, баланс и эммитента.

### История Транзакций 

Щелкая кнопкой мыши по вкладке `Transaction History`, вы можете видеть все записи транзакций, относящихся к данному кошельку.

## Открытие базы данных кошелька

1. Каждый раз, когда клиент открывается повторно, вам нужно щелкнуть кнопкой мыши по `open wallet database` , чтобы выбрать, какой файл кошелька открыть (см. рисунок):

   ![image](../../../assets/gui_5.png)

2. Щелкните кнопкой мыши по `Browse` , чтобы выбрать кошелек (по умолчанию это последний открытый кошелек)

3. Выберите один из форматов файлов, который необходимо открыть: NEP-6 (.json) или SQLite (.db3)

   Клиенты с версией меньше, чем Neo GUI v2.5.2, поддерживают только файлы .db3.

4. Введите пароль и щелкните кнопкой мыши по `OK` для входа в кошелек.

5. Если вы открываете старый кошелек .db3, вам нужно выбрать, обновлять ли кошелек до нового формата NEP-6 в соответствии с сообщение-напоминаем.

   После обновления кошелек NEP-6 может использоваться несколькими клиентами, например, мобильным телефоном, ПК или веб-сайтом. Однако он не может быть открыт в клиентах с версией ранее, чем Neo GUI v2.5.2.

## Изменение пароля

Вы можете изменить пароль кошелька.

![image](../../../assets/gui_6.png)

После изменения пароля не забудьте снова создать резервную копию кошелька, поскольку во всех предыдущих резервных копиях новый пароль будет отсутствовать.

## Восстановление индекса кошелька

Данная опция используется для восстановления индекса кошелька из-за ошибок в клиенте, когда возникает исключение. Индекс кошелька придется изменить в следующих случаях:

- После импорта закрытого ключа.
- Транзакция, которая долгое время не подтверждается.
- Активы кошелька выдают ошибки, а данные блокчейна не подходят к ним.   
- Переключение между главной и тестовой сетями.

Поскольку текущая высота блока очень высока, то внесение изменений в индекс кошелька может занять несколько минут.
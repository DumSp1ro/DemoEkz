
1.Вывод базы из данных может быть в виде таблицы или плиткой (Часто одна страница под каждый вывод) За таблицу отвечает grid,за плитку ListView

Алгоритм
Для получения данных нужно создать контекст


Строчки кода

    public static RulikEntities contextRu;
        public static RulikEntities GetContext()
        {
            if (contextRu == null)
                contextRu = new RulikEntities();
        
            return contextRu;
         }

Вторая строчка нужна будет для кнопок добавить и удалить.

    <Grid.RowDefinitions>
        <RowDefinition Height="50"></RowDefinition>
    </Grid.RowDefinitions>


Данные из таблицы - datagrid. Имя обычно включает DATAGRID И название таблицы из которой берем данные. Создаем стобцы :

            <DataGrid.Columns>
            <DataGridTextColumn Header="№" Binding="{Binding id}" Width="auto"></DataGridTextColumn>
            <DataGridTextColumn Header="логин" Binding="{Binding login}" Width="auto"></DataGridTextColumn>
            <DataGridTextColumn Header="пароль" Binding="{Binding password}" Width="auto"></DataGridTextColumn>
            <DataGridTextColumn Header="тип" Binding="{Binding id_type}" Width="auto"></DataGridTextColumn>
Структура столбца: Заголовок(предпочтительно на русском), Указание на столбец таблицу(Binding="{Binding id}), Ширина(Width = auto) Вывод данных: Название DataGrid, Элементы(ItemsSourse), Название папки, навзание БД, функция для получения контекста, таблица, список(GDadminik.ItemsSource = Models.RulikEntities.GetContext().users.ToList(); })

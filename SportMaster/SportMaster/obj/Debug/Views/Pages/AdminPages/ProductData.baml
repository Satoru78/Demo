   M S B A M L   `   `   `  ????F  BSportMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:SportMaster.Views.Pages.AdminPages"SportMaster.Views.Pages.AdminPages  5      4    .SportMaster.Views.Pages.AdminPages.ProductData   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:SportMaster.Views.Pages.AdminPages     5      -   5          N? Title$  ProductData??5
      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   6*   ?? 5      $??* ?6   6)   ?? 5      $??50 ?6   6*   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $
??Left=?6.   $??Center=?6I   .+?5      ?? -   5        $??BtnBack??5   %   $??
Назад??6   $	??100??6J   $??5q?6V   6c   ?? 5      -   5        $??
BtnCsvSave??5   )   $??Сохранить??6   $	??100??6T   $??5q?6`   6m   5      ?? 5   
   $ 
Horizontal=?6   $??Center=?6.   $??Center=?6K   .+?5      ?? $??ПОИСК:??6   6)   ?? 5      -   5        $??txbSearchProduct??5      $	??250??6c   $??20??6o   6}   5      ?? 5   
   $??Right=?6   $??Center=?61   $ 
Horizontal=?6L   .+?5      ?? -   5        $??cmbSearchCategory??5      $	??100??6f   $??10q?6r   .@?5      ?? .??6   )'Спортивный инвентарь65   ?? 5      .??6   Одежда6'   5      5      ?? 5!   
   $ 
Horizontal=?6   $??Right=?6.   $??Center=?6J   $??	0,0,140,0q?6e   .+?5"      ?? -   5        $??
SwitchView??5"   )   $??Подробнее??6   6W   5#      ? 5%   
   -   5        $??ProductDataView??5%      $??1??6&   $??1??63   .+?5&      ?? -   5        $??ProductDataListView??5&      ??5'      ?? 5(      .R?5)      ?  ? ColumnDefinitions 5*      ?? 5+   "   $??* ?63   6?   ?? 5,   "   $??* ?63   6?   ?? 5-   "   $??* ?63   6?   .+?50      ?? $??0??6A   $	??150??6Q   $	??150??6]   ??6$   ?? *
GetImage+6l   ?? 51      $??1??6)   .+?52   "   ??  ?? ContentStringFormat$# Описание товара??6H   ??6(   ?? *Description+6q   ?? 53   "   $! Производитель:??6I   ??6(   ?? *Manufacturer+6p   ?? 54   "   $ Цена: {0}??6B   ??6(   ?? *Count+6d   55      ?? 56      $??2??6)   .+?57   "   ?? $( "Кол-во на складе: {0}??6L   ??6(   ?? *QuantityInStock+6z   58      59      5;      5=      5>      ? 5@   
   -	   5        $??ProductColumnView??5@      $??1??6(   $y?	Collapsed=?65   .+?5A      &   System.Windows.Controls.DataGrid  -
   5        $??ProductColumn??5A         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6H      Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$ Артикул??6)   	   Width$	 50 6V   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   ?? *	Articul+6c     5D      $ Название??6)   
 6;   ?? *Title+6W     5E      $' !Еденица измерения??6)   
 6D   ?? *Unit+6_     5F      $ Стоимость??6)   
 6<   ?? *Count+6X     5G      $ Скидка??6)   
 69   ?? *
Discount+6X     5H      $  Производитель??6)   
 6@   ?? *Manufacturer+6c     5I      $ Поставщик??6)   
 6<   ?? *
Supplier+6[     5J      $) #Категория продукта??6)   
 6E   ?? *ProductCategory.Title+6q     5K      $, &Количество на складе??6)   
 6G   ?? *QuantitiInStock+6m     5L      $ Описание??6)   
 6;   ?? *Description+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5M      $ Изображение??6-   $		 100 6B      CellTemplate 5N      ?? 5O      .R?5P   "   ?? $??50??6E   $??50??6Q   ??6(   ?? *
GetImage+6^   5Q      5S      5U      5V      ? 5X   
   $??2??6   .+?5Y      ?? $ 
Horizontal=?6   $??Center=?62   $??Center=?6O   .+?5Z      ?? -   5        $??AddProductBtn??5Z   ,   $??Добавить??6   $	??200??6]   $??25??6i   6w   ?? 5[      -   5        $??EditProductBtn??5[   1   $ ??Редактировать??6   $	??200??6d   $??25??6p   $??40,10,40,10q?6|   6?   ?? 5\      -   5        $??DeleteProductBtn??5\   +   $??Удалить??6   $	??200??6b   $??25??6n   6|   5]      5^      5_      5`      
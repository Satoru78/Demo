   M S B A M L   `   `   `  ????@  <Tkani, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Tkani.Views.Pages.MangerPagesTkani.Views.Pages.MangerPages  5      -    'Tkani.Views.Pages.MangerPages.OrderData   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Tkani.Views.Pages.MangerPages     5      -   5          N? Title$  	OrderData??5
      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   6*   ?? 5      $??* ?6   6)   ?? 5      $??50 ?6   6*   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $
??Left=?6.   $??Center=?6I   .+?5      ?? -   5        $??BackBtn??5      $??
Назад??6:   $??10q?6J   $	??100??6V   6d   5      ?? 5   
   $ 
Horizontal=?6   $??Center=?6.   $??Center=?6K   .+?5      ?? $??
Поиск??6   6)   ?? 5      -   5        $??txbSerchOrder??5      $	??200??6]   6k   5      ?? 5   
   $ 
Horizontal=?6   $??Right=?6.   $??Center=?6J   .+?5      ?? -   5        $??	cmbStatus??5      $	??150??6V   $??5q?6b   6o   5      ? 5   
   -   5        $??OrderDataGrid??5      $??1??6   .+?5      &   System.Windows.Controls.DataGrid  -   5        $??	DataOrder??5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Состав??6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   ?? *
Compound+6X     5       $ Дата заказа??6)    6>   ?? *DateOfOrder+6`     5!      $ Дата доставки??6)    6@   ?? *DateOfDelivery+6e     5"      $ Пункт выдачи??6)    6?   ?? *PointOfIssue+6b     5#      $ Имя клиента??6)    6>   ?? *
ClientName+6_     5$      $ Код??6)    66   ?? *Code+6Q     5%      $ Статус??6)    69   ?? *OrderStatus.Title+6a   5'      5(      ? 5)   
   $??2??6   .+?5*      ?? $ 
Horizontal=?6   $??Center=?62   $??Center=?6O   .+?5+      ?? -   5        $??btnAddOrder??5+      $??Добавить??6,   $	??200??6Y   6g   ?? 5,      -   5        $??btnEditOrder??5,      $ ??Редактировать??6-   $	??200??6`   $??	10,0,10,0q?6l   6?   ?? 5-      -	   5        $??btnDeleteOrder??5-      $??Удалить??6/   $	??200??6^   6l   5.      5/      50      52      
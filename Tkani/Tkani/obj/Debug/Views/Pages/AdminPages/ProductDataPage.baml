   M S B A M L   `   `   `  ????@  <Tkani, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tkani.Views.Pages.AdminPagesTkani.Views.Pages.AdminPages  5      2    ,Tkani.Views.Pages.AdminPages.ProductDataPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Tkani.Views.Pages.AdminPages     5      -   5          N? Title$  ProductDataPage??5
      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   6*   ?? 5      $??* ?6   6)   ?? 5      $??50 ?6   6*   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $??Center=?6.   $??Center=?6K   .+?5      ?? $??
ПОИСК??6   6'   ?? 5      -   5        $??txbSearchProduct??5      $	??200??6c   6q   5      ?? 5   
   $ 
Horizontal=?6   $
??Left=?6.   $??Center=?6I   .+?5      ?? -   5        $??BackBtn??5      $??
Назад??6$   $
??100 ??6J   $??10q?6W   6e   5      ? 5   
   -   5        $??GridProduct??5      $??1??6   .+?5      ?? -   5        $??ListProduct??5      ??5      ?? 5      .R?5      ?  ? ColumnDefinitions 5      ?? 5    "   $??* ?63   6?   ?? 5!   "   $??* ?63   6?   ?? 5"   "   $??* ?63   6?   .+?5$      ?? $??1??6)   .+?5%      ?? ??6$   ?? *Title+6@   ?? 5&      ??6$   ?? *Manufacturer+6G   ?? 5'      ??6$   ?? *Description+6F   ?? 5(      ??6$   ?? *Count+6@   5*      5+      5,      5.      5/      ? 51   
   $??2??6   .+?52      ?? $ 
Horizontal=?6   $??Center=?62   $??Center=?6O   .+?53      ?? -   5        $??
AddProduct??53   ,   $??Добавить??6   $	??200??6W   6e   ?? 54      -   5        $??EditProductBtn??54   1   $ ??Редактировать??6   $	??200??6d   $??	10,0,10,0q?6p   6?   ?? 55      -   5        $??DeleteProducBtn??55   +   $??Удалить??6   $	??200??6`   6n   56      57      59      5:      